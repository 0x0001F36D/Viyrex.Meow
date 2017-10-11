# Meow.Schwarz

## Introduction
- ##### �[�J�R�W�Ŷ�
```csharp
using Meow.Schwarz;
using Meow.Schwarz;
```

- ##### �����w��Q�ѪR�� HTML �������B�z
```csharp
var html = 
@"
<!Doctype html>
<html>
    <head>
        <title>I am Viyrex.</title>
    </head>
    <body>
        <p class=""introduction"">I'm Viyrex, A student from Taiwan.<br>My motto is 'No pain, no gain'.<br>If you want to contact me , <a href=""https://github.com/0x0001F36D"">Here</a> is my Github page. Have fun coding!
        </p>
    </body>
<html>
";

var meow = Meow.Load(html);

// 'I am Viyrex.'
var title = meow.Resolve<Title>().Single().Content;
// 'https://github.com/0x0001F36D'
var github = meow.Resolve<A>().Single().Href;
```

- ##### �D HTML �������۩w�q�����]�i���P���o
> *RuntimeTag* ���O(�H�U�٬� *RT* )�O�Ҧ��D HTML �������౵���O
> 
> �����N *RT* �ର *dynamic* �����N�ઽ���s�����Ҫ��ݩ�
> 
> �ഫ�� *dynamic* ������ *RT* ����L�k�s����� *RT* ���󪺦��� *(e.g: TagName, Content)*
```csharp
var html = @"<hello description=""i'm runtime-attribute"" yuyu=""fatty liver"">Runtime-Tag</hello>";
var tag = Meow.Load(html)
            .Resolve<RuntimeTag>()
            .Single();
// 'hello'
var tagName = tag.TagName;
// 'Runtime-Tag'
var content = tag.Content;
// 'i'm runtime-attribute'
var description = tag.DynamicAttributes.Description; 
//Just for access attributes.
dynamic attributes = tag; 
//'fatty liver'
var yuyu = attributes.yuyu; 
```
