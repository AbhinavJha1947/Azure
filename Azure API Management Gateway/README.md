# Azure API Management (APIM) Demo

Azure API Management is a hybrid, multi-cloud management platform for APIs across all environments.

## Key Concepts for Interviews

- **API Gateway**: Entry point for all API requests. Handles routing, security, and throttling.
- **Management Plane**: Where you configure the APIM instance (Azure Portal, CLI, Terraform).
- **Developer Portal**: A customizable web portal for developers to discover and tests APIs.
- **Policies**: XML-based configuration to change the behavior of an API (e.g., transform JSON to XML, rate limiting).
    - **Sections**: Inbound, Backend, Outbound, On-Error.
- **Products & Subscriptions**: APIs are bundled into Products. Developers must subscribe to a Product to get an API Key.

## Included Demos

1. **PolicyExamples.xml**: Common APIM policy snippets (Rate limiting, CORS, Set Header).
2. **README.md**: Explanation of APIM architecture and interview focus areas.
