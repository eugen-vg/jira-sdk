// See https://aka.ms/new-console-template for more information

using Atlassian.Jira;
using Microsoft.Extensions.Configuration;

var settings = new JiraRestClientSettings()
{
	EnableRequestTrace = true
};

var secret = new ConfigurationBuilder()
	.AddUserSecrets<Program>()
	.Build();

var url = secret["JIRA_URL"];
var user = secret["JIRA_USER"];
var password = secret["JIRA_PASSWORD"];
var jiraItem = secret["JIRA_ITEM"];
var pathToImage = secret["PATH_TO_IMAGE"];

var jira = Jira.CreateRestClient(url, user, password, settings);

var issues = from i in jira.Issues.Queryable where i.Key == jiraItem select i;
Console.WriteLine("Fetched {0} issues", issues.Count());
var issue = issues.First();
issue.AddAttachment(pathToImage);
Console.WriteLine("Image was attached");