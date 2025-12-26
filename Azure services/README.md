# Azure Services Overview & Architectural Patterns

This folder contains a high-level overview of Azure's ecosystem and common patterns used in system design interviews.

## Top 5 Azure Architectural Patterns

1. **Cache-Aside Pattern**:
   - **Service**: Azure Cache for Redis.
   - **Use Case**: Loading data on demand into a cache from a data store. Improves performance and maintains consistency between the cache and the underlying data store.

2. **Asynchronous Messaging (Queue-Based Load Leveling)**:
   - **Service**: Azure Service Bus, Storage Queues.
   - **Use Case**: Use a queue that acts as a buffer between a task and a service it invokes in order to smooth intermittent heavy loads.

3. **Circuit Breaker Pattern**:
   - **Service**: Implemented in code (e.g., Polly) or via Service Mesh (Linkerd/Istio in AKS).
   - **Use Case**: Handle faults that might take a variable amount of time to fix when connecting to a remote service or resource.

4. **Static Content Hosting Pattern**:
   - **Service**: Azure Storage (Static Website), Azure Front Door / CDN.
   - **Use Case**: Deploy static content to a cloud-based storage service that can deliver them directly to the client. This can reduce the need for expensive compute instances.

5. **Gatekeeper Pattern**:
   - **Service**: Azure API Management (APIM).
   - **Use Case**: Protect applications and services by using a dedicated host instance that acts as a broker between clients and the application or service, validates and sanitizes requests, and passes them on.

## Interview Quick-Fire Tips

- **IaaS vs. PaaS vs. SaaS**: Know where Azure Functions, App Service, and VMs fit.
- **Availability Sets vs. Availability Zones**: Sets protect against hardware failure in a data center; Zones protect against entire data center failure.
- **LRS vs. GRS**: Locally Redundant Storage (3 copies in 1 DC) vs. Geo-Redundant Storage (secondary region replication).
