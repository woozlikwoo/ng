using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

var answerOne = "готова";
var anotherAnaanswerOne = "я готова";
var anotherAnaanswerOne1 = "готово";
var anotherAnaanswerOne2 = "я готова";


var answerTwo = "Видна, но невесома";

var answerThree = "Энерлиум!";
var anotherAnaanswerThree = "Энерлиум";
var anotherAnaanswerThree1 = "Энерлиум";
var anotherAnaanswerThree2 = "энерлиум";
var anotherAnaanswerThree3 = "энерлиум!";
var anotherAnaanswerThree4 = "Энерлиум!";

var answerFour = "Стол";
var anotheranswerFour = "стол";
var anotheranswerFour1 = "Кухонный стол";
var anotheranswerFour2 = "кухонный стол";

var answerFive = "Шарик";
var answerFive1 = "шар";
var answerFive2 = "воздушный шарик";


var answerSix = "Люкс Порта Верис!";
var answerSix1 = "Люкс Порта Верис!";
var answerSix2 = "Люкс Порта Верис";


var answerSevan = "Я на улице";

var eght = "Топор";

var answerNine = "Тыква";
var answerNine1 = "тыквочка";
var answerNine2 = "маленькая тыква";
var answerNine3 = "тыква";

var answerTen = "Отнесла";
var answerTen1 = "предмет";

var answerEleven = "Печенье";
var answerEleven33 = "Печенька";


var answerEleven1 = "разрушила";

var Token = "7877457011:AAF2IShehGE53CVeKFjgU6dtWAeG1Byxfiw";

var botClient = new TelegramBotClient(Token);
int curentStep = -1;

var a = new CancellationTokenSource();

var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types
};
botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
        pollingErrorHandler: HandlePollingErrorAsync,
        receiverOptions: receiverOptions,
        cancellationToken: a.Token
    );

var aa = 1;


while (aa == 1)
{
    Console.ReadLine();
}


// Send cancellation request to stop bot
a.Cancel();

async Task HandleUpdateAsync(ITelegramBotClient botClient, 
                            Update update, 
                            CancellationToken cancellationToken)
{
    if (update.Message is not { } message)
        return;

    if (message.Text is not { } messageText)
        return;

    var chatId = message.Chat.Id;

    Console.WriteLine($"Пришло сообщение с текстом - {messageText}");

    if (messageText == "/start" && curentStep == -1)
    {
        await Sartingstep(chatId, cancellationToken);
    }

    else if ((messageText.ToLower() == answerOne ||
        messageText.ToLower() == anotherAnaanswerOne ||
        messageText.ToLower() == anotherAnaanswerOne1)
        && curentStep == 1)
    {
        await StepOne(chatId, cancellationToken);
        curentStep++;
    }

    else if (messageText.ToLower() == answerTwo && curentStep == 2)
    {
        await StepTwo(chatId, cancellationToken);
        curentStep++;
    }

    else if (((messageText.ToLower() == answerThree ||
        messageText.ToLower() == anotherAnaanswerThree ||
        messageText.ToLower() == anotherAnaanswerThree1 ||
        messageText.ToLower() == anotherAnaanswerThree2 ||
        messageText.ToLower() == anotherAnaanswerThree3 ||
        messageText.ToLower() == anotherAnaanswerThree4)
        && curentStep == 3))
    {
        await StepThree(chatId, cancellationToken, messageText);
        curentStep++;
    }

    else if ((messageText.ToLower() == answerFour ||
        messageText.ToLower() == anotheranswerFour &&
        messageText.ToLower() == anotheranswerFour1 &&
        messageText.ToLower() == anotheranswerFour2) &&
        curentStep == 4)
    {
        await StepFour(chatId, cancellationToken, messageText);
        curentStep++;
    }

    else if ((messageText.ToLower() == answerFive ||
        messageText.ToLower() == answerFive1 ||
        messageText.ToLower() == answerFive2)
        && curentStep == 5)
    {
        await StepFive(chatId, cancellationToken);
        curentStep++;
    }

    else if (messageText.ToLower() == answerSix ||
        messageText.ToLower() == answerSix ||
        messageText.ToLower() == answerSix && curentStep == 6)
    {
        await StepSix(chatId, cancellationToken, messageText);
        curentStep++;
    }

    else if ((messageText.ToLower() == answerSevan ||
       messageText.ToLower() == answerOne ||
        messageText.ToLower() == anotherAnaanswerOne ||
        messageText.ToLower() == anotherAnaanswerOne1
        && curentStep == 7))
    {
        await StepSeven(chatId, cancellationToken, messageText);
        curentStep++;
    }

    else if ((messageText.ToLower() == eght ||
        messageText.ToLower() == eght ||
        messageText.ToLower() == eght)
        && curentStep == 8)
    {
        await StepEight(chatId, cancellationToken);
        curentStep++;
    }

    else if ((messageText.ToLower() == answerNine ||
        messageText.ToLower() == answerNine1 ||
        messageText.ToLower() == answerNine2 ||
        messageText.ToLower() == answerNine3)

        && curentStep == 9)
    {
        await StepNine(chatId, cancellationToken);
        curentStep++;
    }

    else if ((messageText.ToLower() == answerTen ||
        messageText.ToLower() == answerTen1)
        && curentStep == 10)
    {
        await StepTen(chatId, cancellationToken);
        curentStep++;
    }

    else if ((messageText.ToLower() == answerEleven ||
        messageText.ToLower() == answerEleven ||
        messageText.ToLower() == answerEleven33)
        && curentStep == 11)
    {
        await StepEleven(chatId, cancellationToken);
        curentStep++;
    }
    else if ((messageText.ToLower() == answerEleven1 || messageText.ToLower() == answerOne ||
        messageText.ToLower() == anotherAnaanswerOne ||
        messageText.ToLower() == anotherAnaanswerOne1)
        && curentStep == 12)
    {
        await StepEleven2(chatId, cancellationToken);
        curentStep++;
    }

    else
    {
        await Defolt(chatId, cancellationToken, messageText);
    }
}

async Task Sartingstep(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "Привет, Яночка! Я рад, что ты нашла моё послание! Меня зовут Пумпяка.",
        cancellationToken: cancellationToken);

    Thread.Sleep(800);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "",
        cancellationToken: cancellationToken);

    Thread.Sleep(6500);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "Меня заколдовала злая волшебница превратив в мягкую игрушку и сейчас она пытается испортить новый год всей Деревни сороги, заколдова подарки так, что бы они нестали невилимыми. Ты должна остановить её!",
        cancellationToken: cancellationToken);

    Thread.Sleep(8900);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Но не переживай, ты будешь не одна! Я помогу тебе. Напиши мне когда будешь ГОТОВА!",
       cancellationToken: cancellationToken);

    curentStep = 1;
}

async Task StepOne(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "Отлично, тогда Приступаем",
        cancellationToken: cancellationToken);

    Thread.Sleep(600);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "Колдунья наложила на дом заклинание, что бы ты не смогла выбраться из дома и остановить её! Нам нужно разрушить эти чары. У вас в доме должна быть старая мебель, может комод или стол... попробуй исследовать его, там должна быть подсказка. Напиш мне, если что-то найдёшь",
        cancellationToken: cancellationToken);
}

async Task StepTwo(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "Хм.... Что бы это могло значить?",
        cancellationToken: cancellationToken);

    Thread.Sleep(1200);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "Ну конечно же!",
        cancellationToken: cancellationToken);

    Thread.Sleep(900);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "ЭНЕРГИЯ!!! Для поддержания заклинания долгое время необходим осточник энергии. Что у вас в доме может выделять много энергии?... Тебе необходимо найти источник энергии и там будет заклинание, пришли его мне",
       //text: "Источник заклинания должен всегда находится внутри комнаты. Быстро отыщи предмет, который раньше ты никогда не видела в комнате.",
       cancellationToken: cancellationToken);

    Thread.Sleep(1700);

    //sentMessage = await botClient.SendTextMessageAsync(
    //   chatId: chatId,
    //   text: "Это будет что-то большое, круглое и, скорее всего розового цвета",
    //   cancellationToken: cancellationToken);

    //Thread.Sleep(1700);

    //sentMessage = await botClient.SendTextMessageAsync(
    //   chatId: chatId,
    //   text: "Как отыщешь, напиши мне, что это за предмет!",
    //   cancellationToken: cancellationToken);
}

async Task StepThree(long chatId, CancellationToken cancellationToken, string answer)
{
    Thread.Sleep(300);

    //Message sentMessage = await botClient.SendTextMessageAsync(
    //    chatId: chatId,
    //    text: $"{answer} говоришь?.... Хитро!",
    //    cancellationToken: cancellationToken);

    //Thread.Sleep(900);

    //sentMessage = await botClient.SendTextMessageAsync(
    //    chatId: chatId,
    //    text: $"Тебе необходимо уничтожь его, и тогда ты узнаешь заклинание которое снимет чары с двери",
    //    cancellationToken: cancellationToken);

    //Thread.Sleep(1500);

    //sentMessage = await botClient.SendTextMessageAsync(
    //   chatId: chatId,
    //   text: "Просто скажи его мне и я всё сделаю за тебя. И да... на подоконнике лежат ножницы, вдруг они тебе помогут",
    //   cancellationToken: cancellationToken);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Олично! Так дай мне пару секнд и я разрушу заклининие",
        cancellationToken: cancellationToken);

    Thread.Sleep(1500);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Готово! Источник энергии нейтрализован, но заклинание продержится ещё какое-то время. Мы не можем так долго ждать",
       cancellationToken: cancellationToken);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Готово! Источник энергии нейтрализован, но заклинание продержится ещё какое-то время. Мы не можем так долго ждать",
       cancellationToken: cancellationToken);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Источник заклинания должен всегда находится внутри комнаты.",
       cancellationToken: cancellationToken); 

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Этот предмет должен быть где-то прямо в цент дома.... Что у вас находится в центре гостинной?",
       cancellationToken: cancellationToken);
}

async Task StepFour(long chatId, CancellationToken cancellationToken, string answer)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Обычный стол? думаю, закалдованный предмет должен быть где-то в нём. Обыщи стол...",
        cancellationToken: cancellationToken);

    Thread.Sleep(1000);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Ищи что-то большое, круглое и, скорее всего, розового цвета",
       cancellationToken: cancellationToken);

    Thread.Sleep(1700);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Как отыщешь, напиши мне, что это за предмет!",
       cancellationToken: cancellationToken);
}

async Task StepFive(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Хитро! Тебе необходимо уничтожить этот шарик и ты узнаешь заклинание, скажи мне его и я сниму заклинание которое заперло тебя в доме",
        cancellationToken: cancellationToken);
}

async Task StepSix(long chatId, CancellationToken cancellationToken, string answer)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Так, отойди по дальше от двери, начинаю снимать блокирующее заклинание",
        cancellationToken: cancellationToken);

    Thread.Sleep(900);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Vis elementorum et temporum fluxus, aperite mihi omnes seras!!!!",
       cancellationToken: cancellationToken);

    Thread.Sleep(1700);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Попробуй. Сейчас дверь долна поддаться. ",
       cancellationToken: cancellationToken);

    Thread.Sleep(1700);

    sentMessage = await botClient.SendTextMessageAsync(
       chatId: chatId,
       text: "Напиши мне как будешь на улице!",
       cancellationToken: cancellationToken);
}

async Task StepSeven(long chatId, CancellationToken cancellationToken, string answer)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Прекрасно! Рад, что у тебя получилось. Теперь Нам нужно рассправиться со злой колдуньей и всем людям в Сорогах вернуть их подарки!",
        cancellationToken: cancellationToken);

    Thread.Sleep(900);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Но тебе нужна будет помощь. Найди волшебное дерево во дворе и посмотре, что оно тебе подарит. Та найдёшь его во дворе по яркому свету",
        cancellationToken: cancellationToken);

    Thread.Sleep(900);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Напиши мне, что тебе подарит волшебное новогоднее дерево и мы подумаем, что делать дальше",
        cancellationToken: cancellationToken);
}

async Task StepEight(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Топор??? Оригинально. Он нам пригодится. Бери его с собой!",
        cancellationToken: cancellationToken);

    Thread.Sleep(600);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"пока ты искала топор, я заметил, что хитра колдунья наложила заклинание и на твою карету. Беги в машину и найди предмет которогог там никогда небыло, что бы расколдовать машину.",
        cancellationToken: cancellationToken);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"И кстати, напиши мне потом, что это за предмет",
        cancellationToken: cancellationToken);

    Thread.Sleep(900);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"И не забудь топор)",
        cancellationToken: cancellationToken);
}

async Task StepNine(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Ха-ха-ха. При помощи этой тыквы она превратила в тыкву твою машину, отнеси эту тыкву домой и заклятие будет снято",
        cancellationToken: cancellationToken);

    Thread.Sleep(900);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Напиши мне, что ты готова, когда отнесёшь тыкву в дом",
        cancellationToken: cancellationToken);
}

async Task StepTen(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Супер! Я тоже зря времени не терял, я узнал, что вся сила Злой колуньи заключена в магическом предмете который находится где-то за пределами деревни. Садись в машину и едь прямо пока не увидишь знак!",
        cancellationToken: cancellationToken);

    Thread.Sleep(1900);

    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Ну т.е. Не знак, а столб... первый столб за пределами деревни без света)) Как доберёшься, обыщи столб и найдёи предмет в котором сила злой колдуньи. Напиши мне как найдёшь",
        cancellationToken: cancellationToken);
}

async Task StepEleven(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Да, похоже это оно. Примени к нему волшебный топор, покончим с сучкой. И напши мне как колдовство будет разрушено",
        cancellationToken: cancellationToken);

    Thread.Sleep(1000);
}

async Task StepEleven2(long chatId, CancellationToken cancellationToken)
{
    Thread.Sleep(300);

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Ты справилась!!! Я вижу как чары разрушаются по всей деревне и люди получают свои подарки! Ты спасла новый Год.",
        cancellationToken: cancellationToken);

    Thread.Sleep(1000);

    Thread.Sleep(300);
    sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: $"Теперь ты можешь возвращаться домой, твой подарок уже ждёт тебя под ёлкой!!! С новым годом!",
        cancellationToken: cancellationToken);
}

async Task Defolt(long chatId, CancellationToken cancellationToken, string answer)
{
    string text0 = "Не то. Может ошибку в слове сделала?";
    string text1 = $"{answer} - не подходит. Может попробуй чьл-то другое?";
    string text2 = $"Неверно. Точно правильно написала?";
    string text3 = $"проверил вариант - {answer}. Не заработало попробуй ещё";

    Random rnd = new Random();

    var result = rnd.Next(0, 4);

    Message sentMessage = new Message();
    switch (result)
    {
        case 0:
            Thread.Sleep(300);
             sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: text0,
                cancellationToken: cancellationToken);
            break;

        case 1:
            Thread.Sleep(300);
             sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: text1,
                cancellationToken: cancellationToken);
            break;

        case 2:
            Thread.Sleep(300);
            sentMessage = await botClient.SendTextMessageAsync(
               chatId: chatId,
               text: text2,
               cancellationToken: cancellationToken);
            break;

        case 3:
            Thread.Sleep(300);
            sentMessage = await botClient.SendTextMessageAsync(
               chatId: chatId,
               text: text3,
               cancellationToken: cancellationToken);
            break;
    }

}

Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };

    Console.WriteLine(ErrorMessage);
    return Task.CompletedTask;
}



