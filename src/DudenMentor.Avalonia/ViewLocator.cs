using Avalonia.Controls;
using Avalonia.Controls.Templates;
using DudenMentor.Avalonia.ViewModels;
using System;
using DryIoc;

namespace DudenMentor.Avalonia
{
    public class ViewLocator : IDataTemplate
    {
        public IControl Build(object data)
        {
            var name = data.GetType().FullName!.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)InversionOfControl.Container.Resolve(type, IfUnresolved.Throw);
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
