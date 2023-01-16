# Teams OpenAI Conversation Bot in C#.
Hi, thanks for stopping by my github and checking out Teams OpenAI Converation Bot in C#!
This project was inspired by the following two projects.
- [SidU](https://github.com/SidU)'s [Bot Framework GPT-3 demo](https://github.com/SidU/botframework-gpt3)
- [leeford](https://github.com/leeford)'s [Teams OpenAI Conversation Bot](https://github.com/leeford/teams-openai-bot#readme)

I started this project because I wanted a similar bot in C#. 
This bot is using [Betalgo.OpenAI.GPT3](https://github.com/betalgo/openai), the OpenAI .Net library developed by [Betalgo](https://github.com/betalgo).

## Just send a message as a prompt! 
This bot treats a message as a prompt. You can write your own, or simply try out a few from [Awesome ChatGPT Prompts](https://github.com/f/awesome-chatgpt-prompts)
![image](https://user-images.githubusercontent.com/12367582/212578745-691328fb-1ef5-4a67-81e2-f0c6ca5843b2.png)
![image](https://user-images.githubusercontent.com/12367582/212578761-e1dc5819-d7a9-43bd-843a-f2ceb6ee6551.png)


## How to try out this bot
### Prerequisite
- [OpenAI account](https://beta.openai.com/) and API Key
- If you do not have your own Microsoft Tenant and Teams.. 
  - Have a testing tenant (you can get one by signing up for the [M365 Developer Program](https://developer.microsoft.com/en-us/microsoft-365/dev-program) for free!)
- Run ngrok for the port 3978 (you can change the port number in launchSettings.json)
- Register your app that has the bot capability using Azure Portal & Developer Portal
  - Register your app (in my case a simple bot) on AAD by following the instruction here: [Register a new application](https://learn.microsoft.com/en-us/azure/healthcare-apis/register-application#register-a-new-application) 
  - [Register your app to Microsoft Teams using Developer Portal.](https://learn.microsoft.com/en-us/microsoftteams/platform/concepts/build-and-test/teams-developer-portal#register-an-app) 
    - Get Application ID (Client ID) from the Azure Portal. 
  - Register your bot on Developer Portal.
    - The bot end point is: [your ngrok url]/api/messages
    - Save bot id & bot password somewhere as we will need them.
  - Download the app's manifest as we will need it to sideload the bot.
- Visual Studio 2022

### Set up
- Open the solution file in Visual Studio 2022.
- Update MicrosoftAppId & MicrosoftAppPassword in appSettings.json to be your bot id & password. 
- Update openAiService.ApiKey to be yours in EchoBot.cs.
- Now hit F5 and run the bot. 
- Go to your Teams and sideload your bot to any type of chat. 
- Enjoy interacting with your bot!

## Deploy the bot to Azure

To learn more about deploying a bot to Azure, see [Deploy your bot to Azure](https://aka.ms/azuredeployment) for a complete list of deployment instructions.

## Further reading

- [Bot Framework Documentation](https://docs.botframework.com)
- [Bot Basics](https://docs.microsoft.com/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0)
- [Activity processing](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-concept-activity-processing?view=azure-bot-service-4.0)
- [Azure Bot Service Introduction](https://docs.microsoft.com/azure/bot-service/bot-service-overview-introduction?view=azure-bot-service-4.0)
- [Azure Bot Service Documentation](https://docs.microsoft.com/azure/bot-service/?view=azure-bot-service-4.0)
- [.NET Core CLI tools](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
- [Azure CLI](https://docs.microsoft.com/cli/azure/?view=azure-cli-latest)
- [Azure Portal](https://portal.azure.com)
- [Language Understanding using LUIS](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/)
- [Channels and Bot Connector Service](https://docs.microsoft.com/en-us/azure/bot-service/bot-concepts?view=azure-bot-service-4.0)
