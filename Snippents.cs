using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polab4
{
    class Snippents
    {
        /*<?xml version="1.0" encoding="utf-8"?>
 <CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
   <CodeSnippet Format="1.0.0">
     <Header>
       <Title>Quick sort</Title>
       <Shortcut>quick</Shortcut>
       <Description>sorts an array with a quick sort </Description>
       <Author>Gleb</Author>
     </Header>
     <Snippet>
       <Code Language="CSharp">
         <![CDATA[int[] QuickSort(int[] array, int minIndex, int maxIndex)
                 {
                   if (minIndex >= maxIndex)
                    {
                      return array;
                     }

                   var pivotIndex = Partition(array, minIndex, maxIndex);
                   QuickSort(array, minIndex, pivotIndex - 1);
                   QuickSort(array, pivotIndex + 1, maxIndex);

                   return array;
                 }
     ]]>
       </Code>
     </Snippet>
   </CodeSnippet>
 </CodeSnippets>
     }*/


/*
 * <?xml version="1.0" encoding="utf-8"?>
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
<CodeSnippet Format="1.0.0">
<Header>
<Title>RootOf</Title>
<Shortcut>Rof</Shortcut>
<Description>Возведение числа под любой корень</Description>
<Author>Gleb</Author>
</Header>
<Snippet>
<Code Language="csharp">
<![CDATA[Math.Pow( a ,1/$Number$);]]>
</Code>
<Declarations>
<Literal>
  <ID>Number</ID>
  <ToolTip>Choose the number you want the root of.</ToolTip>
  <Default>2</Default>
</Literal>
</Declarations>
</Snippet>
</CodeSnippet>
</CodeSnippets>
*/

}
}
