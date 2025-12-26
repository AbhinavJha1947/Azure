# Azure Container Demos (ACI & Container Apps)

Azure provides several ways to run containerized applications without managing VMs.

## Key Concepts for Interviews

### Azure Container Instances (ACI)
- **Fast Isolation**: Run a single container in seconds.
- **No Orchestration**: Best for simple applications, task automation, and build jobs.
- **Pay per second**: You pay only for the exact amount of CPU and memory used.

### Azure Container Apps (ACA) / App Containers
- **Serverless Containers**: Built on Kubernetes (K8s) but abstract away the complexity.
- **Scaling with KEDA**: Can scale to zero and scale based on HTTP traffic, messages in a queue, etc.
- **Dapr Integration**: Built-in support for Distributed Application Runtime (Dapr).
- **Environment**: Containers are grouped into environments that share the same VNET.

## Included Demos

1. **Dockerfile**: Standard multi-stage build for a .NET application.
2. **README.md**: Detailed comparison of ACI, ACA, and AKS.
