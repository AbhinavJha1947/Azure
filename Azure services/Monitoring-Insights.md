# Azure Monitor & Application Insights

## Key Concepts

- **Metrics**: Numerical values that describe some aspect of a system at a particular time.
- **Logs**: Different types of data organized into records with different sets of properties for each type.
- **Distributed Tracing**: Tracking requests as they flow through multiple services.
- **Sampling**: Reducing the amount of telemetry data sent to save cost.

## Instrumentation Example (C#)

```csharp
// In Program.cs
builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"]);

// In a Controller/Service
private readonly TelemetryClient _telemetryClient;

public void TrackCustomEvent()
{
    _telemetryClient.TrackEvent("UserLoggedIn");
    _telemetryClient.TrackMetric("ProcessTime", 123.45);
}
```

## Log Analytics Queries (KQL)

```kusto
// Find 404 errors in the last 24 hours
requests
| where success == false
| where resultCode == "404"
| where timestamp > ago(24h)
| count

// Find slow dependencies
dependencies
| where success == true
| summarize avg(duration) by name
| order by avg_duration desc
```
