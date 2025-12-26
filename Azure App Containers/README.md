# Azure App Containers (Container Apps) Demo

This folder focuses on Azure Container Apps, the modern serverless container platform.

## Key Interview Questions

- **When to choose ACA over AKS?** ACA is better when you want Kubernetes features (scaling, VNETs, ingress) without the operational overhead of managing a cluster.
- **What is KEDA?** Kubernetes Event-Driven Autoscaling. ACA uses KEDA to scale based on events.
- **How does ACA handle ingress?** It has built-in HTTP ingress, so you don't need to configure a separate Load Balancer.

## Included Demos

1. **ACAConfiguration.yaml**: Sample YAML for deploying a Container App with scaling rules.
