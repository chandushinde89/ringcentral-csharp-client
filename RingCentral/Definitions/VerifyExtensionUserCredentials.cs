namespace RingCentral
{
    public partial class VerifyExtensionUserCredentials
    {
        // User password of an extension
        public string @password { get; set; }
        // User pin of an extension
        public string @ivrPin { get; set; }
        // Secret question of an extension user
        public SecretQuestionInfoVerificationRequest @secretQuestion { get; set; }
    }
}
