using DevExpress.Mvvm;

namespace Webinar.Tests
{
    internal class DummyServiceForMessageBox: IMessageBoxService
    {
        private readonly MessageResult _resultToTest;
        public DummyServiceForMessageBox(MessageResult resultToTest)
        {
            this._resultToTest = resultToTest;
        }
        MessageResult IMessageBoxService.Show(string messageBoxText, string caption,
            MessageButton button, MessageIcon icon, MessageResult defaultResult)
        {
            return this._resultToTest;
        }
    }
}
