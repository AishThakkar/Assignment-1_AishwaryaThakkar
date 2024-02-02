using System;
using System.Reflection;

namespace Assignment_1_AishwaryaThakkar.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}