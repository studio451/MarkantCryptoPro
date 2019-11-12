using Net.Asn1.Reader;
using System;
using System.Globalization;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Расширение для класса BerReader
    /// </summary>
    internal static class BerReaderExtension
    {
        /// <summary>
        /// Печатает ASN.1 структуру
        /// </summary>
        /// <param name="reader">Объект BerReader</param>
        /// <param name="node">Узел дерева</param>
        /// <param name="relativeResult">Предыдущий результат работы данного метода</param>
        /// <param name="depth">Глубина вложенности</param>
        /// <param name="dumpValues">Печатать значения</param>
        /// <returns>Структура ASN.1 представленная в виде строки</returns>
        internal static string PrintStructure(this BerReader reader, InternalNode node, string relativeResult, int depth, bool dumpValues)
        {

            var offsetAndLength = String.Format("({0},{1})",
                node.StartPosition.ToString(CultureInfo.InvariantCulture),
                node.Length.ToString(CultureInfo.InvariantCulture));

            var structure = String.Format("{0} {1}",
                offsetAndLength,
                (node.Identifier.Class == Asn1Class.ContextSpecific)
                    ? String.Format("{0} ({1})", node.Identifier.Class, (int)node.Identifier.Tag)
                    : node.Identifier.Tag.ToString());

            if (dumpValues)
            {
                if (node.NodeType == Asn1NodeType.Primitive)
                {
                    string stringValue;
                    node.RawValue = reader.ReadContentAsBuffer(node);

                    switch (node.Identifier.Tag)
                    {
                        case Asn1Type.ObjectIdentifier:
                            stringValue = node.ReadContentAsObjectIdentifier();
                            break;
                        case Asn1Type.PrintableString:
                        case Asn1Type.Ia5String:
                        case Asn1Type.Utf8String:
                            stringValue = node.ReadContentAsString();
                            break;
                        case Asn1Type.GeneralizedTime:
                        case Asn1Type.UtcTime:
                            stringValue = node.ReadConventAsDateTimeOffset().ToString();
                            break;
                        case Asn1Type.Integer:
                            stringValue = node.ReadContentAsBigInteger().ToString();
                            break;
                        case Asn1Type.Boolean:
                            stringValue = node.ReadContentAsBoolean().ToString();
                            break;
                        default:
                            stringValue = node.RawValue.ToHexString();
                            break;
                    }

                    structure = string.Format("{0} : {1}", structure, stringValue);
                }
            }

            for (int i = 0; i < depth; i++)
            {
                structure = "\t" + structure;
            }

            string res = relativeResult + Environment.NewLine + structure;

            var innerdepth = (node.ChildNodes.Count > 0) ? depth + 1 : depth;

            foreach (var innerNode in node.ChildNodes)
            {
                res = reader.PrintStructure(innerNode, res, innerdepth, dumpValues);
            }

            return res;
        }
    }
}
