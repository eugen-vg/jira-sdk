# Sample to test Jira API
The app fetch item from Jira and attach an image to it.
Before running it, you must set the following environment variables with .net secrets.
Run the following commands in the project folder:
```
dotnet user-secrets init
dotnet user-secrets set "JIRA_URL" "..."
dotnet user-secrets set "JIRA_USER" "..."
dotnet user-secrets set "JIRA_PASSWORD" "..."
dotnet user-secrets set "JIRA_ITEM" "..."
dotnet user-secrets set "PATH_TO_IMAGE" "..."
```