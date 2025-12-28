# Azure Interview Questions & Answers

## Table of Contents

| No. | Question |
| --- | :--- |
| 1 | [What is Microsoft Azure and why is it important?](#1-what-is-microsoft-azure-and-why-is-it-important) |
| 2 | [Explain the difference between PaaS, SaaS, and IaaS.](#2-explain-the-difference-between-paas-saas-and-iaas) |
| 3 | [What are Azure Regions and Availability Zones?](#3-what-are-azure-regions-and-availability-zones) |
| 4 | [What is a Resource Group in Azure?](#4-what-is-a-resource-group-in-azure) |
| 5 | [What is the Azure Resource Manager (ARM)?](#5-what-is-the-azure-resource-manager-arm) |
| 6 | [Explain the difference between Vertical Scaling and Horizontal Scaling.](#6-explain-the-difference-between-vertical-scaling-and-horizontal-scaling) |
| 7 | [What is an Azure App Service Plan?](#7-what-is-an-azure-app-service-plan) |
| 8 | [What are Azure Functions?](#8-what-are-azure-functions) |
| 9 | [Differentiate between Azure Functions and WebJobs.](#9-differentiate-between-azure-functions-and-webjobs) |
| 10 | [What are the different types of Azure Storage?](#10-what-are-the-different-types-of-azure-storage) |
| 11 | [Explain the concept of Blob Storage tiers (Hot, Cool, Archive).](#11-explain-the-concept-of-blob-storage-tiers-hot-cool-archive) |
| 12 | [What is Cosmos DB?](#12-what-is-cosmos-db) |
| 13 | [What is an Azure Virtual Network (VNet)?](#13-what-is-an-azure-virtual-network-vnet) |
| 14 | [What is a Network Security Group (NSG)?](#14-what-is-a-network-security-group-nsg) |
| 15 | [Explain VNet Peering.](#15-explain-vnet-peering) |
| 16 | [What is Azure Active Directory (Azure AD) / Microsoft Entra ID?](#16-what-is-azure-active-directory-azure-ad--microsoft-entra-id) |
| 17 | [What is Multi-Factor Authentication (MFA)?](#17-what-is-multi-factor-authentication-mfa) |
| 18 | [What is Role-Based Access Control (RBAC)?](#18-what-is-role-based-access-control-rbac) |
| 19 | [What is Azure Logic Apps?](#19-what-is-azure-logic-apps) |
| 20 | [What is Azure Service Bus?](#20-what-is-azure-service-bus) |
| 21 | [Difference between Azure Queue Storage and Service Bus Queues.](#21-difference-between-azure-queue-storage-and-service-bus-queues) |
| 22 | [What is Azure SQL Database?](#22-what-is-azure-sql-database) |
| 23 | [What are DTUs in Azure SQL Database?](#23-what-are-dtus-in-azure-sql-database) |
| 24 | [What is Azure Key Vault?](#24-what-is-azure-key-vault) |
| 25 | [What is Azure Application Insights?](#25-what-is-azure-application-insights) |
| 26 | [What is Azure Traffic Manager?](#26-what-is-azure-traffic-manager) |
| 27 | [What is a Managed Identity in Azure?](#27-what-is-a-managed-identity-in-azure) |
| 28 | [What is Azure DevOps?](#28-what-is-azure-devops) |
| 29 | [What is Azure Kubernetes Service (AKS)?](#29-what-is-azure-kubernetes-service-aks) |
| 30 | [What is the difference between Azure Load Balancer and Application Gateway?](#30-what-is-the-difference-between-azure-load-balancer-and-application-gateway) |
| 31 | [What is Azure Content Delivery Network (CDN)?](#31-what-is-azure-content-delivery-network-cdn) |
| 32 | [What is the Azure SLA (Service Level Agreement)?](#32-what-is-the-azure-sla-service-level-agreement) |
| 33 | [What are Logic Apps?](#33-what-are-logic-apps) |
| 34 | [What is the usage of Azure API Management?](#34-what-is-the-usage-of-azure-api-management) |
| 35 | [What is Azure Data Factory?](#35-what-is-azure-data-factory) |
| 36 | [What are Quickstart templates?](#36-what-are-quickstart-templates) |
| 37 | [What is Azure Monitor?](#37-what-is-azure-monitor) |
| 38 | [What is the difference between Public Cloud, Private Cloud, and Hybrid Cloud?](#38-what-is-the-difference-between-public-cloud-private-cloud-and-hybrid-cloud) |
| 39 | [What is a Fault Domain and an Update Domain?](#39-what-is-a-fault-domain-and-an-update-domain) |
| 40 | [What is Azure Blob Storage?](#40-what-is-azure-blob-storage) |

---

### 1. What is Microsoft Azure and why is it important?

**Microsoft Azure** is a cloud computing platform and set of services offered by Microsoft. It allows you to build, deploy, and manage applications and services through global data centers. It provides a wide range of cloud services, including computing, analytics, storage, and networking.

**Importance:**
*   **Scalability:** Easily scale resources up or down based on demand.
*   **Cost-Effective:** Pay-as-you-go model reduces upfront infrastructure costs.
*   **Global Reach:** Deploy applications near users worldwide for better performance.
*   **Security:** High-level security and compliance certifications.
*   **Hybrid Capability:** Seamlessly integrates with on-premises infrastructure.

[Back to Top](#table-of-contents)

---

### 2. Explain the difference between PaaS, SaaS, and IaaS.

*   **IaaS (Infrastructure as a Service):** You rent IT infrastructure—servers and virtual machines (VMs), storage, networks, operating systems—from a cloud provider on a pay-as-you-go basis. **Example:** Azure Virtual Machines.
*   **PaaS (Platform as a Service):** Provides a computing platform and environment for developers and operations teams to build, test, deploy, manage, and update software applications. You manage the applications and services, while the cloud provider manages the underlying infrastructure. **Example:** Azure App Service, Azure SQL Database.
*   **SaaS (Software as a Service):** A method for delivering software applications over the Internet, on demand and typically on a subscription basis. Cloud providers host and manage the software application and underlying infrastructure. **Example:** Microsoft 365, Dynamics 365.

[Back to Top](#table-of-contents)

---

### 3. What are Azure Regions and Availability Zones?

*   **Azure Regions:** A set of data centers deployed within a latency-defined perimeter and connected through a dedicated regional low-latency network.
*   **Availability Zones:** Physically separate locations within an Azure region. Each Availability Zone is made up of one or more data centers equipped with independent power, cooling, and networking. They offer high availability and protect against data center failures.

[Back to Top](#table-of-contents)

---

### 4. What is a Resource Group in Azure?

A **Resource Group** is a container that holds related resources for an Azure solution. The resource group includes those resources that you want to manage as a group. You decide how to allocate resources to resource groups based on what makes the most sense for your organization. Resources generally share the same lifecycle (create, update, delete) within a group.

[Back to Top](#table-of-contents)

---

### 5. What is the Azure Resource Manager (ARM)?

**Azure Resource Manager (ARM)** is the deployment and management service for Azure. It provides a management layer that enables you to create, update, and delete resources in your Azure account. You manage your infrastructure through a declarative template (ARM Templates) rather than through scripts.

[Back to Top](#table-of-contents)

---

### 6. Explain the difference between Vertical Scaling and Horizontal Scaling.

*   **Vertical Scaling (Scale Up/Down):** Increasing or decreasing the capacity of an existing resource. For example, moving to a larger VM size with more CPU and RAM.
*   **Horizontal Scaling (Scale Out/In):** Adding or removing instances of a resource. For example, adding more VMs to a load balancer configuration to handle increased traffic.

[Back to Top](#table-of-contents)

---

### 7. What is an Azure App Service Plan?

An **App Service Plan** defines a set of compute resources for a web app to run. It acts as a container for your web apps and functions. It determines the region, number of VM instances, size of VM instances, and pricing tier (Free, Shared, Basic, Standard, Premium, Isolated) for the apps associated with it.

[Back to Top](#table-of-contents)

---

### 8. What are Azure Functions?

**Azure Functions** is a serverless compute service that lets you run event-triggered code without having to explicitly provision or manage infrastructure. You pay only for the compute time you consume.

[Back to Top](#table-of-contents)

---

### 9. Differentiate between Azure Functions and WebJobs.

*   **Azure Functions:** Serverless, event-driven, pay-per-execution (Consumption plan), automatic scaling. Best for small pieces of code or "glue" logic.
*   **WebJobs:** Part of Azure App Service. Runs background tasks in the COMPUTE context of your App Service (Web App). Best if you already have an App Service and want to run background tasks on the same VM.

[Back to Top](#table-of-contents)

---

### 10. What are the different types of Azure Storage?

*   **Azure Blob Storage:** Object storage for massive amounts of unstructured data (text, binary).
*   **Azure Files:** Managed file shares for cloud or on-premises deployments (SMB protocol).
*   **Azure Queue Storage:** Messaging store for reliable messaging between application components.
*   **Azure Table Storage:** NoSQL store for schemaless storage of structured data.
*   **Azure Disk Storage:** Block-level storage volumes for Azure VMs.

[Back to Top](#table-of-contents)

---

### 11. Explain the concept of Blob Storage tiers (Hot, Cool, Archive).

*   **Hot Tier:** Optimized for storing data that is accessed frequently. Highest storage cost, lowest access cost.
*   **Cool Tier:** Optimized for storing data that is infrequently accessed and stored for at least 30 days. Lower storage cost than Hot, higher access cost.
*   **Archive Tier:** Optimized for storing data that is rarely accessed and stored for at least 180 days with flexible latency requirements (e.g., hours). Lowest storage cost, highest retrieval cost.

[Back to Top](#table-of-contents)

---

### 12. What is Cosmos DB?

**Azure Cosmos DB** is a fully managed NoSQL database for modern app development. It offers single-digit millisecond response times, and automatic and instant scalability, along with guaranteed speed at any scale. It supports multiple APIs including JSON (Core), MongoDB, Cassandra, Gremlin, and Table.

[Back to Top](#table-of-contents)

---

### 13. What is an Azure Virtual Network (VNet)?

**Azure VNet** is the fundamental building block for your private network in Azure. VNet enables many types of Azure resources, such as Azure Virtual Machines (VMs), to securely communicate with each other, the internet, and on-premises networks. It provides isolation and segmentation.

[Back to Top](#table-of-contents)

---

### 14. What is a Network Security Group (NSG)?

A **Network Security Group (NSG)** allows you to filter network traffic to and from Azure resources in an Azure virtual network. An NSG contains security rules that allow or deny inbound network traffic to, or outbound network traffic from, several types of Azure resources.

[Back to Top](#table-of-contents)

---

### 15. Explain VNet Peering.

**VNet Peering** connects two Azure virtual networks. Once peered, the virtual networks appear as one for connectivity purposes. Traffic between virtual machines in peered virtual networks creates a private connection through the Microsoft backbone network, without needing gateways or public Internet.

[Back to Top](#table-of-contents)

---

### 16. What is Azure Active Directory (Azure AD) / Microsoft Entra ID?

**Microsoft Entra ID** (formerly Azure Active Directory) is Microsoft's cloud-based identity and access management service. It helps your employees sign in and access resources in:
*   External resources, such as Microsoft 365, the Azure portal, and thousands of other SaaS applications.
*   Internal resources, such as apps on your corporate network and intranet, along with any cloud apps developed by your own organization.

[Back to Top](#table-of-contents)

---

### 17. What is Multi-Factor Authentication (MFA)?

**MFA** is a process where a user is prompted during the sign-in process for an additional form of identification, such as to enter a code on their cellphone or to provide a fingerprint scan. It provides a higher level of security than just a password.

[Back to Top](#table-of-contents)

---

### 18. What is Role-Based Access Control (RBAC)?

**RBAC** is a system that provides fine-grained access management of scale. Using RBAC, you can segregate duties within your team and grant only the amount of access to users that they need to perform their jobs.

[Back to Top](#table-of-contents)

---

### 19. What is Azure Logic Apps?

**Azure Logic Apps** is a cloud service that helps you create and run automated workflows that integrate your apps, data, services, and systems. You can use it to build scalable solutions for app integration, data integration, system integration, enterprise application integration (EAI), and business-to-business (B2B) communication.

[Back to Top](#table-of-contents)

---

### 20. What is Azure Service Bus?

**Azure Service Bus** is a fully managed enterprise integration message broker. It is most commonly used to decouple applications and services from each other and is a reliable and secure platform for asynchronous transfer of data and state.

[Back to Top](#table-of-contents)

---

### 21. Difference between Azure Queue Storage and Service Bus Queues.

*   **Azure Queue Storage:** Simple queue for storing large numbers of messages. Good for simple work backlogs. Can store millions of messages.
*   **Service Bus Queues:** More advanced messaging features like Publish/Subscribe (via Topics), First-In-First-Out (FIFO) ordering, transactions, and duplicate detection. Better for enterprise messaging.

[Back to Top](#table-of-contents)

---

### 22. What is Azure SQL Database?

**Azure SQL Database** is a fully managed platform as a service (PaaS) database engine that handles most of the database management functions such as upgrading, patching, backups, and monitoring without user involvement. It runs on the latest stable version of the SQL Server database engine.

[Back to Top](#table-of-contents)

---

### 23. What are DTUs in Azure SQL Database?

**DTU (Database Transaction Unit)** is a unit of measure for the resources that are guaranteed to be available to a standalone Azure SQL Database. It represents a blended measure of CPU, memory, and data I/O and transaction log I/O.

[Back to Top](#table-of-contents)

---

### 24. What is Azure Key Vault?

**Azure Key Vault** is a cloud service for securely storing and accessing secrets. A secret is anything that you want to tightly control access to, such as API keys, passwords, certificates, or cryptographic keys.

[Back to Top](#table-of-contents)

---

### 25. What is Azure Application Insights?

**Application Insights** is a feature of Azure Monitor, is an extensible Application Performance Management (APM) service for developers and DevOps professionals. Use it to monitor your live applications. It will automatically detect performance anomalies, and includes powerful analytics tools to help you diagnose issues and to understand what users actually do with your app.

[Back to Top](#table-of-contents)

---

### 26. What is Azure Traffic Manager?

**Azure Traffic Manager** is a DNS-based traffic load balancer. This service allows you to distribute traffic to your public facing applications across the global Azure regions. It also provides your public endpoints with high availability and quick responsiveness.

[Back to Top](#table-of-contents)

---

### 27. What is a Managed Identity in Azure?

**Managed Identities** provide an identity for applications to use when connecting to resources that support Azure AD authentication. Applications may use the managed identity to obtain Azure AD tokens. This removes the need for developers to manage credentials (like connection strings or passwords) within the code.

[Back to Top](#table-of-contents)

---

### 28. What is Azure DevOps?

**Azure DevOps** provides developer services for support teams to plan work, collaborate on code development, and build and deploy applications. Services include:
*   **Azure Boards:** Agile planning.
*   **Azure Repos:** Git repositories.
*   **Azure Pipelines:** CI/CD automation.
*   **Azure Test Plans:** Testing tools.
*   **Azure Artifacts:** Package management.

[Back to Top](#table-of-contents)

---

### 29. What is Azure Kubernetes Service (AKS)?

**AKS** simplifies deploying a managed Kubernetes cluster in Azure by offloading the operational overhead to Azure. As a hosted Kubernetes service, Azure handles critical tasks, like health monitoring and maintenance. The Kubernetes masters are managed by Azure (and free), you only manage and pay for the agent nodes.

[Back to Top](#table-of-contents)

---

### 30. What is the difference between Azure Load Balancer and Application Gateway?

*   **Azure Load Balancer:** Works at Layer 4 (Transport Layer - TCP/UDP). Distributes traffic based on IP address and port. Good for non-HTTP(S) traffic.
*   **Azure Application Gateway:** Works at Layer 7 (Application Layer - HTTP/HTTPS). Supports web-specific features like SSL termination, cookie-based session affinity, and URL-based routing. Includes a Web Application Firewall (WAF).

[Back to Top](#table-of-contents)

---

### 31. What is Azure Content Delivery Network (CDN)?

**Azure CDN** is a global content delivery network solution for delivering high-bandwidth content. It caches static web content at strategically placed locations (Points of Presence) to provide maximum throughput for delivering content to users.

[Back to Top](#table-of-contents)

---

### 32. What is the Azure SLA (Service Level Agreement)?

An **SLA** describes Microsoft's commitments for uptime and connectivity. Each Azure service has a specific SLA (e.g., 99.9%, 99.95%, 99.99%). If Microsoft does not achieve and maintain the Service Levels for each Service as described in the SLA, you might be eligible for a credit towards a portion of your monthly service fees.

[Back to Top](#table-of-contents)

---

### 33. What are Logic Apps?

(Similar to #19) **Logic Apps** provide a way to simplify and implement scalable integrations and workflows in the cloud. It provides a visual designer to model and automate your process as a series of steps known as a workflow.

[Back to Top](#table-of-contents)

---

### 34. What is the usage of Azure API Management?

**Azure API Management** helps organizations publish APIs to external, partner, and internal developers to unlock the potential of their data and services. It provides a gateway for the API calls, a publisher portal for API management, and a developer portal for API documentation and onboarding.

[Back to Top](#table-of-contents)

---

### 35. What is Azure Data Factory?

**Azure Data Factory** is a cloud-based data integration service that allows you to create data-driven workflows in the cloud for orchestrating and automating data movement and data transformation. It's often used for ETL (Extract, Transform, Load) processes.

[Back to Top](#table-of-contents)

---

### 36. What are Quickstart templates?

**Quickstart templates** are ready-to-deploy ARM templates that are community-contributed. They provide a quick way to deploy various Azure resources and solutions without writing the template from scratch.

[Back to Top](#table-of-contents)

---

### 37. What is Azure Monitor?

**Azure Monitor** helps you maximize the availability and performance of your applications and services. It delivers a comprehensive solution for collecting, analyzing, and acting on telemetry from your cloud and on-premises environments. It includes Metrics, Logs, and Alerts.

[Back to Top](#table-of-contents)

---

### 38. What is the difference between Public Cloud, Private Cloud, and Hybrid Cloud?

*   **Public Cloud:** Services are offered over the public internet and available to anyone who wants to purchase them. (e.g., Azure, AWS).
*   **Private Cloud:** Computing resources used exclusively by a single business or organization. Can be located on-premises or hosted by a third-party service provider.
*   **Hybrid Cloud:** Combines public and private clouds, bound together by technology that allows data and applications to be shared between them.

[Back to Top](#table-of-contents)

---

### 39. What is a Fault Domain and an Update Domain?

*   **Fault Domain:** A logical group of hardware that shares a common power source and network switch. (Think: Rack). Azure ensures VMs in an Availability Set are spread across different Fault Domains.
*   **Update Domain:** A logical group of underlying hardware that can undergo maintenance or be rebooted at the same time. Azure ensures updates are pushed to one Update Domain at a time.

[Back to Top](#table-of-contents)

---

### 40. What is Azure Blob Storage?

(See #10, expanded) **Blob Storage** is optimized for storing massive amounts of unstructured data. It's ideal for:
*   Serving images or documents directly to a browser.
*   Storing files for distributed access.
*   Streaming video and audio.
*   Writing to log files.
*   Storing data for backup and restore, disaster recovery, and archiving.

[Back to Top](#table-of-contents)

---
