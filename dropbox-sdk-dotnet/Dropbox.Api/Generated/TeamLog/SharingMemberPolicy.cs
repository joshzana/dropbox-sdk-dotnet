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
    /// <para>External sharing policy</para>
    /// </summary>
    public class SharingMemberPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharingMemberPolicy> Encoder = new SharingMemberPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharingMemberPolicy> Decoder = new SharingMemberPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharingMemberPolicy" />
        /// class.</para>
        /// </summary>
        public SharingMemberPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Allow</para>
        /// </summary>
        public bool IsAllow
        {
            get
            {
                return this is Allow;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Allow, or <c>null</c>.</para>
        /// </summary>
        public Allow AsAllow
        {
            get
            {
                return this as Allow;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Forbid</para>
        /// </summary>
        public bool IsForbid
        {
            get
            {
                return this is Forbid;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Forbid, or <c>null</c>.</para>
        /// </summary>
        public Forbid AsForbid
        {
            get
            {
                return this as Forbid;
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
        /// <para>Encoder for  <see cref="SharingMemberPolicy" />.</para>
        /// </summary>
        private class SharingMemberPolicyEncoder : enc.StructEncoder<SharingMemberPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharingMemberPolicy value, enc.IJsonWriter writer)
            {
                if (value is Allow)
                {
                    WriteProperty(".tag", "allow", writer, enc.StringEncoder.Instance);
                    Allow.Encoder.EncodeFields((Allow)value, writer);
                    return;
                }
                if (value is Forbid)
                {
                    WriteProperty(".tag", "forbid", writer, enc.StringEncoder.Instance);
                    Forbid.Encoder.EncodeFields((Forbid)value, writer);
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
        /// <para>Decoder for  <see cref="SharingMemberPolicy" />.</para>
        /// </summary>
        private class SharingMemberPolicyDecoder : enc.UnionDecoder<SharingMemberPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharingMemberPolicy" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharingMemberPolicy Create()
            {
                return new SharingMemberPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharingMemberPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "allow":
                        return Allow.Decoder.DecodeFields(reader);
                    case "forbid":
                        return Forbid.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The allow object</para>
        /// </summary>
        public sealed class Allow : SharingMemberPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Allow> Encoder = new AllowEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Allow> Decoder = new AllowDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Allow" /> class.</para>
            /// </summary>
            private Allow()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Allow</para>
            /// </summary>
            public static readonly Allow Instance = new Allow();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Allow" />.</para>
            /// </summary>
            private class AllowEncoder : enc.StructEncoder<Allow>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Allow value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Allow" />.</para>
            /// </summary>
            private class AllowDecoder : enc.StructDecoder<Allow>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Allow" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Allow Create()
                {
                    return Allow.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The forbid object</para>
        /// </summary>
        public sealed class Forbid : SharingMemberPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Forbid> Encoder = new ForbidEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Forbid> Decoder = new ForbidDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Forbid" /> class.</para>
            /// </summary>
            private Forbid()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Forbid</para>
            /// </summary>
            public static readonly Forbid Instance = new Forbid();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Forbid" />.</para>
            /// </summary>
            private class ForbidEncoder : enc.StructEncoder<Forbid>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Forbid value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Forbid" />.</para>
            /// </summary>
            private class ForbidDecoder : enc.StructDecoder<Forbid>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Forbid" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Forbid Create()
                {
                    return Forbid.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SharingMemberPolicy
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
