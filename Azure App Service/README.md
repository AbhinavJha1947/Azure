# Azure App Service Demo

Azure App Service is an HTTP-based service for hosting web applications, REST APIs, and mobile backends.

## Key Concepts for Interviews

- **PaaS (Platform as a Service)**: Azure manages the underlying infrastructure, OS, and runtime.
- **App Service Plan (ASP)**: Defines the compute resources (CPU, RAM) and cost. All apps in an ASP share the resources.
- **Deployment Slots**: Allow you to host different versions of your app (e.g., Staging, Production). You can "swap" slots with zero downtime.
- **Scaling**:
    - **Scale Up**: Increase resources (CPU/RAM) of the existing instances.
    - **Scale Out**: Increase the number of instances.
- **Continuous Deployment**: Tight integration with Azure DevOps and GitHub Actions.

## Included Demos

1. **AppSettingsDemo.cs**: Example of reading configuration from Environment Variables/App Settings in ASP.NET Core.
