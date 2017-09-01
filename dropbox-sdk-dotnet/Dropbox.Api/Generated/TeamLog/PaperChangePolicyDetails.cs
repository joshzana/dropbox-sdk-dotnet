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
    /// <para>Enabled or disabled Dropbox Paper for the team.</para>
    /// </summary>
    public class PaperChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperChangePolicyDetails> Encoder = new PaperChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperChangePolicyDetails> Decoder = new PaperChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New Dropbox Paper policy.</param>
        /// <param name="previousValue">Previous Dropbox Paper policy. Might be missing due to
        /// historical data gap.</param>
        public PaperChangePolicyDetails(PaperPolicy newValue,
                                        PaperPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New Dropbox Paper policy.</para>
        /// </summary>
        public PaperPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous Dropbox Paper policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public PaperPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperChangePolicyDetails" />.</para>
        /// </summary>
        private class PaperChangePolicyDetailsEncoder : enc.StructEncoder<PaperChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.PaperPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.PaperPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperChangePolicyDetails" />.</para>
        /// </summary>
        private class PaperChangePolicyDetailsDecoder : enc.StructDecoder<PaperChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperChangePolicyDetails Create()
            {
                return new PaperChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.PaperPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.PaperPolicy.Decoder.Decode(reader);
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
