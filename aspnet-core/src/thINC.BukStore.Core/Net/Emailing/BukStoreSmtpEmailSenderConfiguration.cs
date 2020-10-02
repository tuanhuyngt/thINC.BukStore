using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace thINC.BukStore.Net.Emailing
{
    public class BukStoreSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public BukStoreSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}