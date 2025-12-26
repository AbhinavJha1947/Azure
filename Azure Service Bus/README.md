# Azure Service Bus Demo

Azure Service Bus is a fully managed enterprise message broker with message queues and publish-subscribe topics.

## Key Concepts for Interviews

- **Queues**: First-In-First-Out (FIFO) message delivery. Single consumer.
- **Topics & Subscriptions**: Publish-Subscribe model. Multiple consumers. Subscriptions can have **Filters** to receive only specific messages.
- **Peek Lock vs. Receive and Delete**:
    - **Peek Lock**: Receiver locks the message, processes it, and then completes it. If it fails, the lock expires and the message is available again. (At-Least-Once)
    - **Receive and Delete**: Message is deleted from the queue immediately upon being read. (At-Most-Once)
- **Dead-Letter Queues (DLQ)**: A sub-queue where messages are moved if they cannot be delivered or processed.
- **Sessions**: Ensures ordered delivery of related messages (FIFO per session).

## Included Demos

1. **QueueSender.cs**: Logic to send messages to a Service Bus queue.
2. **TopicPublisher.cs**: Logic to publish messages to a topic.
3. **QueueReceiver.cs**: Logic to consume messages from a queue using Peek-Lock.
