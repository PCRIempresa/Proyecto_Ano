using System.Runtime.InteropServices;
namespace ADODB
{
    internal class Connection
    {
        public object CursorLocation { get; internal set; }

        [Guid("0000052F-0000-0010-8000-00AA006D2EA4")]
        public enum CursorLocationEnum
        {
            adUseNone = 1,
            adUseServer = 2,
            adUseClient = 3,
            adUseClientBatch = 3
        }
    }
}