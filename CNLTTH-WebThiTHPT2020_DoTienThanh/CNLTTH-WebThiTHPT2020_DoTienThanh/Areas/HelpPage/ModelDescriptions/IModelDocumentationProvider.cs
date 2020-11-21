using System;
using System.Reflection;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}