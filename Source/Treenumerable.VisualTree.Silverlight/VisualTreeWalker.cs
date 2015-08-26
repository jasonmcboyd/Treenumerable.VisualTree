using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Treenumerable.VisualTree
{
    public class VisualTreeWalker : ITreeWalker<DependencyObject>
    {
        public IEnumerable<DependencyObject> GetChildren(DependencyObject node)
        {
            int count = VisualTreeHelper.GetChildrenCount(node);
            for (int i = 0; i < count; i++ )
            {
                yield return VisualTreeHelper.GetChild(node, i);
            }
        }

        public IEnumerable<DependencyObject> GetAncestors(DependencyObject node)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(node);
            while (parent != null)
            {
                yield return parent;
                parent = VisualTreeHelper.GetParent(parent);
            }
        }
    }
}
