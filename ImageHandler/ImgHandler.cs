using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageHandler
{
    public class ImgHandler : IHttpHandler
    {
        private int Width = 0;
        private int Height = 0;

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Params["height"] != null)
            {
                try
                {
                    Height = int.Parse(context.Request.Params["height"]);
                }
                catch
                {
                    Height = 0;
                }
            }
            if (context.Request.Params["width"] != null)
            {
                try
                {
                    Width = int.Parse(context.Request.Params["width"]);
                }
                catch
                {
                    Width = 0;
                }
            }
            if(Width<=0 && Height <= 0)
            {
                context.Response.Clear();
                context.Response.ContentType = ImgHelper.getContentType(context.Request.PhysicalPath);
                context.Response.WriteFile(context.Request.PhysicalPath);
                context.Response.End();
            }
            else
            {
                context.Response.Clear();
                context.Response.ContentType = ImgHelper.getContentType(context.Request.PhysicalPath);

                byte[] buffer = ImgHelper.ResizeImage(context.Request.PhysicalPath, Width, Height);
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.End();
            }
        }

     }
}