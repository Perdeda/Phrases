using Microsoft.AspNetCore.Builder;
using System.Reflection.PortableExecutable;
using System.Text;
using WebApplicationEmpty;
using WebApplicationEmpty.Map;
using static System.Runtime.InteropServices.JavaScript.JSType;


AppMapping map = new AppMapping(args);





//request.Path - ���� � ������� "/Oleg"
//request.QueryString - ������ � �������� � ������� "?cringe=ALE&prikol=1"
//�� ���� ���������� � ����� ����� ������ foreach (var param in context.Request.Query) key � value 
//��������� �������: string name = context.Request.Query["name"]
//context.Response.Redirect("/new") - ��������
