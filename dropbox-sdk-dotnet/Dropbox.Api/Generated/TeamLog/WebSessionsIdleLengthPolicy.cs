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
    /// <para>Web sessions idle length policy.</para>
    /// </summary>
    public class WebSessionsIdleLengthPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<WebSessionsIdleLengthPolicy> Encoder = new WebSessionsIdleLengthPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<WebSessionsIdleLengthPolicy> Decoder = new WebSessionsIdleLengthPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="WebSessionsIdleLengthPolicy" />
        /// class.</para>
        /// </summary>
        public WebSessionsIdleLengthPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Defined</para>
        /// </summary>
        public bool IsDefined
        {
            get
            {
                return this is Defined;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Defined, or <c>null</c>.</para>
        /// </summary>
        public Defined AsDefined
        {
            get
            {
                return this as Defined;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Undefined</para>
        /// </summary>
        public bool IsUndefined
        {
            get
            {
                return this is Undefined;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Undefined, or <c>null</c>.</para>
        /// </summary>
        public Undefined AsUndefined
        {
            get
            {
                return this as Undefined;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="WebSessionsIdleLengthPolicy" />.</para>
        /// </summary>
        private class WebSessionsIdleLengthPolicyEncoder : enc.StructEncoder<WebSessionsIdleLengthPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(WebSessionsIdleLengthPolicy value, enc.IJsonWriter writer)
            {
                if (value is Defined)
                {
                    WriteProperty(".tag", "defined", writer, enc.StringEncoder.Instance);
                    Defined.Encoder.EncodeFields((Defined)value, writer);
                    return;
                }
                if (value is Undefined)
                {
                    WriteProperty(".tag", "undefined", writer, enc.StringEncoder.Instance);
                    Undefined.Encoder.EncodeFields((Undefined)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="WebSessionsIdleLengthPolicy" />.</para>
        /// </summary>
        private class WebSessionsIdleLengthPolicyDecoder : enc.UnionDecoder<WebSessionsIdleLengthPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="WebSessionsIdleLengthPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override WebSessionsIdleLengthPolicy Create()
            {
                return new WebSessionsIdleLengthPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override WebSessionsIdleLengthPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "defined":
                        return Defined.Decoder.DecodeFields(reader);
                    case "undefined":
                        return Undefined.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Defined idle session length.</para>
        /// </summary>
        public sealed class Defined : WebSessionsIdleLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Defined> Encoder = new DefinedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Defined> Decoder = new DefinedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Defined" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Defined(DurationLogInfo value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Defined" /> class.</para>
            /// </summary>
            private Defined()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public DurationLogInfo Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Defined" />.</para>
            /// </summary>
            private class DefinedEncoder : enc.StructEncoder<Defined>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Defined value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.TeamLog.DurationLogInfo.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Defined" />.</para>
            /// </summary>
            private class DefinedDecoder : enc.StructDecoder<Defined>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Defined" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Defined Create()
                {
                    return new Defined();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Defined DecodeFields(enc.IJsonReader reader)
                {
                    return new Defined(global::Dropbox.Api.TeamLog.DurationLogInfo.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Undefined idle session length.</para>
        /// </summary>
        public sealed class Undefined : WebSessionsIdleLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Undefined> Encoder = new UndefinedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Undefined> Decoder = new UndefinedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Undefined" /> class.</para>
            /// </summary>
            private Undefined()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Undefined</para>
            /// </summary>
            public static readonly Undefined Instance = new Undefined();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Undefined" />.</para>
            /// </summary>
            private class UndefinedEncoder : enc.StructEncoder<Undefined>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Undefined value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Undefined" />.</para>
            /// </summary>
            private class UndefinedDecoder : enc.StructDecoder<Undefined>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Undefined" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Undefined Create()
                {
                    return Undefined.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : WebSessionsIdleLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
