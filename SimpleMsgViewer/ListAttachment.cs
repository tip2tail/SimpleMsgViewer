using MsgReader.Outlook;

namespace SimpleMsgViewer
{
    internal class ListAttachment()
    {
        public Storage.Attachment attachment { get; set; }

        public override string ToString()
        {
            return attachment.FileName;
        }
    }
}
