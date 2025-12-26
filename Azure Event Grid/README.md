# Azure Event Grid Demo

Azure Event Grid is a highly scalable, serverless event broker.

## Key Concepts for Interviews

- **Events vs. Messages**:
    - **Messages**: Contain data; the producer expects the consumer to do something with it (Service Bus).
    - **Events**: Contain notification of something that happened; the producer has no expectation of what happens next (Event Grid).
- **Topics**: Where publishers send events.
    - **System Topics**: Built-in topics (e.g., Storage Blob Created).
    - **Custom Topics**: Your application's events.
- **Subscriptions**: Where events are routed to handlers (Functions, Webhooks, Logic Apps).
- **Event Schemas**: Event Grid Schema vs. CloudEvents Schema (standard).
- **Dead Lettering**: Storing undelivered events in Blob Storage.
- **Filtering**: Routing events based on event type or subject.

## Included Demos

1. **EventPublisher.cs**: Publishing custom events using the .NET SDK.
2. **README.md**: Comparison of Service Bus, Event Hubs, and Event Grid.
