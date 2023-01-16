// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.18.1

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System.Linq;
using Microsoft.Identity.Client;

namespace teams_openai_bot_csharp.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        { 
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = "<Your Open AI API Secret>"
            });

            var completionResult = await openAiService.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                Prompt = turnContext.Activity.Text,
                Temperature = 0.9f, 
                MaxTokens = 150,
                TopP = 1, 
                FrequencyPenalty = 0, 
                PresencePenalty = 0.6f,
                StopAsList = new List<string>{ "Human:", " AI:" },
                LogProbs = 1,
            }, Models.TextDavinciV3);

            string replyText = null;
            if (completionResult.Successful)
            {
                replyText = completionResult.Choices.FirstOrDefault().Text.Trim();
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }

                Console.WriteLine($"{completionResult.Error.Code}: {completionResult.Error.Message}");
            }
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome!";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
