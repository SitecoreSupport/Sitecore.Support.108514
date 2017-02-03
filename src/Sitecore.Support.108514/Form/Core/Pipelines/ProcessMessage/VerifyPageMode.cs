namespace Sitecore.Support.Form.Core.Pipelines.ProcessMessage
{
  using Sitecore.Diagnostics;                           
  using Sitecore.WFFM.Abstractions.Mail;

  public class VerifyPageMode
  {
    [UsedImplicitly]
    public void Process(ProcessMessageArgs args)
    {
      if (Context.PageMode.IsNormal)
      {
        return;
      }

      Log.Info($"Sending message was aborted due to preview mode (Sitecore.Support.108514)", this);

      args.AbortPipeline();
    }
  }
}