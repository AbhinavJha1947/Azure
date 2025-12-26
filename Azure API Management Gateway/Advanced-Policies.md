# Azure API Management Gateway - Advanced Demos

This folder contains advanced policy examples.

## Advanced Pattern: API Mocking
Mocking allows frontend developers to work in parallel with backend developers by returning static responses from the gateway.

### Policy Example (Mock-Response)
Add this to the `inbound` section of a mocked operation:

```xml
<mock-response status-code="200" content-type="application/json" />
```

## Advanced Pattern: Transformation
Converting XML to JSON or vice-versa.

```xml
<xml-to-json kind="javascript-friendly" apply="always" consider-accept-header="false" />
```
