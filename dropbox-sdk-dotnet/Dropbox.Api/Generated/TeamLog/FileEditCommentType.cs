// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The file edit comment type object</para>
    /// </summary>
    public class FileEditCommentType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileEditCommentType> Encoder = new FileEditCommentTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileEditCommentType> Decoder = new FileEditCommentTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileEditCommentType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public FileEditCommentType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileEditCommentType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileEditCommentType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the file edit comment type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileEditCommentType" />.</para>
        /// </summary>
        private class FileEditCommentTypeEncoder : enc.StructEncoder<FileEditCommentType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileEditCommentType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileEditCommentType" />.</para>
        /// </summary>
        private class FileEditCommentTypeDecoder : enc.StructDecoder<FileEditCommentType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileEditCommentType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileEditCommentType Create()
            {
                return new FileEditCommentType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileEditCommentType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
