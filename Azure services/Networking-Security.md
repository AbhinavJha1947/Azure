# Azure Networking: VNETs & Private Endpoints

Security and isolation are critical for enterprise Azure deployments.

## Key Concepts

- **VNET (Virtual Network)**: Your own private network in the cloud.
- **Subnet**: A range of IP addresses in your VNET.
- **VNET Integration (Outbound)**: Allows an App Service or Function to access resources inside a VNET (like a private SQL DB).
- **Private Endpoint (Inbound)**: Gives a service (like Redis or Storage) a private IP address from your VNET. This disables public access.
- **NSG (Network Security Group)**: A firewall for subnets.

## Interview Scenario: Secure 3-Tier App

1. **Frontend**: App Service with VNET Integration.
2. **Backend**: Internal Load Balancer or Private Link to an internal API.
3. **Database**: Azure SQL with a Private Endpoint.
4. **Result**: No public internet traffic reaches the DB or internal API.

## Configuration (Bicep fragment)

```bicep
// Creating a Private Endpoint for Redis
resource privateEndpoint 'Microsoft.Network/privateEndpoints@2021-05-01' = {
  name: 'redis-private-endpoint'
  location: location
  properties: {
    subnet: {
      id: vnet.properties.subnets[0].id
    }
    privateLinkServiceConnections: [
      {
        name: 'redis-connection'
        properties: {
          privateLinkServiceId: redisCache.id
          groupIds: [
            'redisCache'
          ]
        }
      }
    ]
  }
}
```

## Common Questions

1. **Q: Difference between Service Endpoints and Private Endpoints?**
   - **Service Endpoint**: Traffic still goes over the Azure backbone to the *public* IP of the service, but it's restricted to your VNET.
   - **Private Endpoint**: The service gets a *private* IP inside your VNET. More secure, supports on-premises via VPN/ExpressRoute.

2. **Q: Why use VNET Integration for App Service?**
   - To access the database via its Private Endpoint.
   - To access on-premises resources via a VPN/ExpressRoute connected VNET.
