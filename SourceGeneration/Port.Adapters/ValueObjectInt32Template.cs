﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 17.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SourceGeneration.Port.Adapters
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ValueObjectInt32Template : ValueObjectInt32TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ");
            
            #line 3 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.NamespacePath));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// ");
            
            #line 6 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameJapanese));
            
            #line default
            #line hidden
            this.Write("\r\n    /// </summary>\r\n    public record class ");
            
            #line 8 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        #region Fields\r\n\r\n        /// <summary>\r\n        /// デフォルト\r\n    " +
                    "    /// </summary>\r\n        public static readonly ");
            
            #line 15 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(" Default = new(");
            
            #line 15 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.DefaultValue.ToString("#,0").Replace(',', '_')));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n        /// <summary>\r\n        /// 最小値\r\n        /// </summary>\r\n        pri" +
                    "vate const int _minimumValue = ");
            
            #line 20 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.MinimumValue.ToString("#,0").Replace(',', '_')));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n        /// <summary>\r\n        /// 最大値\r\n        /// </summary>\r\n        priv" +
                    "ate const int _maximumValue = ");
            
            #line 25 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.MaximumValue.ToString("#,0").Replace(',', '_')));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n        #endregion\r\n\r\n        #region Constructors\r\n\r\n        /// <summary>\r" +
                    "\n        /// ");
            
            #line 32 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameJapanese));
            
            #line default
            #line hidden
            this.Write("を初期化します。\r\n        /// </summary>\r\n        /// <param name=\"value\">値</param>\r\n    " +
                    "    private ");
            
            #line 35 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(@"(int value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 値を取得します。
        /// </summary>
        public int Value { get; }

        #endregion

        #region Methods
        
        /// <summary>
        /// 数値を解析します。
        /// </summary>
        /// <param name=""num"">数値</param>
        /// <returns>解析した結果を返します。</returns>
        public static ");
            
            #line 58 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(" Parse(int num)\r\n        {\r\n            bool success = Validate(num, out var mess" +
                    "age);\r\n            if (!success) throw new ArgumentException(message, nameof(num" +
                    "));\r\n\r\n            ");
            
            #line 63 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(@" result = new(num);

            return result;
        }

        /// <summary>
        /// 数値を解析します。
        /// </summary>
        /// <param name=""num"">数値</param>
        /// <param name=""result"">結果</param>
        /// <returns>解析した結果を返します。</returns>
        public static bool TryParse(int num, out ");
            
            #line 74 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(@" result)
        {
            return TryParse(num, out result, out _);
        }

        /// <summary>
        /// 数値を解析します。
        /// </summary>
        /// <param name=""num"">数値</param>
        /// <param name=""result"">結果</param>
        /// <param name=""message"">メッセージ</param>
        /// <returns>解析した結果を返します。</returns>
        public static bool TryParse(int num, out ");
            
            #line 86 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(" result, out string message)\r\n        {\r\n            bool success = Validate(num," +
                    " out message);\r\n            if (success)\r\n            {\r\n                result " +
                    "= new ");
            
            #line 91 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameEnglish));
            
            #line default
            #line hidden
            this.Write(@"(num);
            }
            else
            {
                result = Default;
            }

            return success;
        }

        /// <summary>
        /// 数値を検証します。
        /// </summary>
        /// <param name=""num"">数値</param>
        /// <param name=""message"">メッセージ</param>
        /// <returns>検証に成功した場合は、 <c>true</c>。それ以外の場合は、 <c>false</c>。</returns>
        private static bool Validate(int num, out string message)
        {
            bool success = _minimumValue <= num && num <= _maximumValue;

            if (success)
            {
                message = string.Empty;
            }
            else
            {
                message = $""");
            
            #line 117 "C:\Users\ma310\source\repos\SourceGeneration\SourceGeneration\Port.Adapters\ValueObjectInt32Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_context.ClassNameJapanese));
            
            #line default
            #line hidden
            this.Write("は、 {_minimumValue:#,0} ～ {_maximumValue:#,0} の範囲で入力してください。\";\r\n            }\r\n\r\n  " +
                    "          return success;\r\n        }\r\n\r\n        #endregion\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class ValueObjectInt32TemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}