using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PizzariaHelloWorld.Dialogs
{
    [Serializable]
    public class QnaDialog : QnAMakerDialog
    {

        public QnaDialog() : base(new QnAMakerService(new QnAMakerAttribute(ConfigurationManager.AppSettings["QnaSubscriptionKey"], ConfigurationManager.AppSettings["QnaKnowledgebaseId"], "Não encontrei sua resposta", 0.5)))
        {
        }

        /// MÉTODO UTILIZADO PARA FORMATAR UMA RESPOSTA
        /*
        protected override async Task RespondFromQnAMakerResultAsync(IDialogContext context, IMessageActivity message, QnAMakerResults result)
        {

            Activity activity   = ((Activity)context.Activity).CreateReply();
            var responta        = result.Answers.First().Answer;
            var dadosResposta   = responta.Split(';');

            if (responta.Length == 1)
            {
                await context.PostAsync(responta);
                return;
            }

            var titulo      = dadosResposta[0];
            var descricao   = dadosResposta[1];
            var url         = dadosResposta[2];
            var urlImagem   = dadosResposta[3];

            HeroCard card = new HeroCard { Title = titulo, Subtitle = descricao };
            card.Buttons  = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Compre Agora", value:url) };
            card.Images   = new List<CardImage> { new CardImage(url = urlImagem) };

            activity.Attachments.Add(card.ToAttachment());

            await context.PostAsync(activity);
        }
        */
    }
}