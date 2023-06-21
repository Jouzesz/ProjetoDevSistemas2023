using System.ComponentModel;
using System.Reflection;
namespace PizzariaDoZe;

public static class ClassEnums
{
    public enum EnumProdutoTipo
    {
        [Description("Refrigerante")]
        Refrigerante = 'R',
        [Description("Cerveja")]
        Cerveja = 'C',
        [Description("Suco")]
        Suco = 'S',
        [Description("Água")]
        Agua = 'A',
        [Description("Outros")]
        Outros = 'O'
    }
    public enum EnumFuncionarioGrupo
    {
        [Description("Administrador")]
        Admin = 1,
        [Description("Atendente")]
        Atende = 2,
        [Description("Entregador")]
        Entrega = 3,
    }
    public enum EnumSaborCategoria
    {
        [Description("Tradicional")]
        Tradicional = 'T',
        [Description("Especial")]
        Especial = 'E'
    }
    public enum EnumSaborTipo
    {
        [Description("Doce")]
        Doce = 'D',
        [Description("Salgada")]
        Salgada = 'S'
    }

    public enum EnumValorTamanho
    {
        [Description("Pequena")]
        Pequena = 'P',
        [Description("Média")]
        Media = 'M',
        [Description("Grande")]
        Grande = 'G',
        [Description("Família")]
        Familia = 'F'
    }

    public static string GetDescription(this Enum GenericEnum)
    {
        Type genericEnumType = GenericEnum.GetType();
        MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
        if ((memberInfo != null && memberInfo.Length > 0))
        {
            var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if ((_Attribs != null && _Attribs.Count() > 0))
            {
                return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
            }
        }
        return GenericEnum.ToString();
    }
}