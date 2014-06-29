namespace NServiceBus
{
    using Transports;

    /// <summary>
    /// Transport definition for MSMQ
    /// </summary>
    public class Msmq : TransportDefinition
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public Msmq()
        {
            RequireOutboxConsent = true;
        }
    }
}