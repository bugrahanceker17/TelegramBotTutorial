using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

TelegramBotClient botClient = new TelegramBotClient("TELEGRAM_BOT_TOKEN");

// Mesaj göndermek istediğiniz sohbet'in ID'si. (Tarayıcıdan Telegram Web sayfasını açın ve sohbete girdiğinizde path'deki sohbet ID'sini alın)
long targetChatId = 00000;

// Metin gönderme
await botClient.SendTextMessageAsync(
    chatId: targetChatId,
    text: "Bu bir test mesajıdır."
);

// Fotoğrafı gönderme
using (FileStream photoStream = new FileStream( @"FILE_PATH", FileMode.Open))
{
    await botClient.SendPhotoAsync(
        chatId: targetChatId,
        photo: new InputOnlineFile(photoStream),
        caption: "Bu bir test fotoğrafıdır."
    );
}

Console.WriteLine("Message sent successfully");