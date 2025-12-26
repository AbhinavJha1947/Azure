# Azure Container Instances - Deployment Example

# Basic ACI deployment using Azure CLI
# This would create a container instance from a public image

az container create \
  --resource-group myResourceGroup \
  --name mycontainer \
  --image mcr.microsoft.com/azuredocs/aci-helloworld:latest \
  --cpu 1 \
  --memory 1 \
  --restart-policy OnFailure \
  --ports 80 \
  --dns-name-label myapp-unique-dns \
  --environment-variables 'APP_ENV'='production'

# With private registry
az container create \
  --resource-group myResourceGroup \
  --name mycontainer \
  --image myregistry.azurecr.io/myapp:latest \
  --registry-login-server myregistry.azurecr.io \
  --registry-username <username> \
  --registry-password <password> \
  --cpu 2 \
  --memory 4 \
  --ports 80 443
