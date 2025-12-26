# Infrastructure as Code (Bicep)

Bicep is a Domain Specific Language (DSL) for deploying Azure resources declaratively.

## Why Bicep?
- **Native to Azure**: Immediate support for all resource types.
- **Modular**: Break down complex deployments into reusable blocks.
- **Integration**: Pipelines can deploy Bicep files directly.

## Example: Deploying an App Service
```bicep
param webAppName string = 'demo-app-${uniqueString(resourceGroup().id)}'
param sku string = 'F1'
param location string = resourceGroup().location

resource appServicePlan 'Microsoft.Web/serverfarms@2021-03-01' = {
  name: '${webAppName}-plan'
  location: location
  sku: {
    name: sku
  }
  kind: 'linux'
}

resource webApp 'Microsoft.Web/sites@2021-03-01' = {
  name: webAppName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    siteConfig: {
      linuxFxVersion: 'DOTNET|6.0'
    }
  }
}
```

## Pipeline Integration (YAML fragment)
```yaml
- task: AzureResourceManagerTemplateDeployment@3
  inputs:
    deploymentScope: 'Resource Group'
    azureResourceManagerConnection: 'MyServiceConnection'
    resourceGroupName: 'MyResourceGroup'
    location: 'East US'
    templateLocation: 'Linked artifact'
    csmFile: 'main.bicep'
```
