# Azure Functions Demo

Azure Functions is a serverless compute service that enables you to run event-triggered code without having to explicitly provision or manage infrastructure.

## Key Concepts for Interviews

- **Serverless Compute**: Only runs when triggered, scales automatically, and you pay only for the resources consumed during execution.
- **Triggers & Bindings**:
    - **Trigger**: Defines how a function is invoked (e.g., HTTP, Timer, Queue, Service Bus).
    - **Input Binding**: Data passed to the function from another service.
    - **Output Binding**: Data the function sends to another service.
- **Consumption Plan vs. Premium Plan vs. Dedicated (App Service) Plan**:
    - **Consumption**: Automatic scaling, pay-as-you-go, cold start issues.
    - **Premium**: Pre-warmed instances to avoid cold starts, VNET integration.
    - **Dedicated**: Run on dedicated VMs, good for long-running processes.
- **Cold Start**: The delay that occurs when a function is triggered after being idle.

## Included Demos

1. **HttpTriggerDemo.cs**: Demonstrates a REST API endpoint.
2. **ServiceBusTriggerDemo.cs**: Demonstrates processing messages from an Azure Service Bus queue.

## Configuration

Ensure `local.settings.json` is configured with your connection strings.
