// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The save copy reference error object</para>
    /// </summary>
    public class SaveCopyReferenceError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SaveCopyReferenceError> Encoder = new SaveCopyReferenceErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SaveCopyReferenceError> Decoder = new SaveCopyReferenceErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SaveCopyReferenceError" />
        /// class.</para>
        /// </summary>
        public SaveCopyReferenceError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidCopyReference</para>
        /// </summary>
        public bool IsInvalidCopyReference
        {
            get
            {
                return this is InvalidCopyReference;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidCopyReference, or <c>null</c>.</para>
        /// </summary>
        public InvalidCopyReference AsInvalidCopyReference
        {
            get
            {
                return this as InvalidCopyReference;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TooManyFiles</para>
        /// </summary>
        public bool IsTooManyFiles
        {
            get
            {
                return this is TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyFiles, or <c>null</c>.</para>
        /// </summary>
        public TooManyFiles AsTooManyFiles
        {
            get
            {
                return this as TooManyFiles;
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
        /// <para>Encoder for  <see cref="SaveCopyReferenceError" />.</para>
        /// </summary>
        private class SaveCopyReferenceErrorEncoder : enc.StructEncoder<SaveCopyReferenceError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SaveCopyReferenceError value, enc.IJsonWriter writer)
            {
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is InvalidCopyReference)
                {
                    WriteProperty(".tag", "invalid_copy_reference", writer, enc.StringEncoder.Instance);
                    InvalidCopyReference.Encoder.EncodeFields((InvalidCopyReference)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
                    return;
                }
                if (value is NotFound)
                {
                    WriteProperty(".tag", "not_found", writer, enc.StringEncoder.Instance);
                    NotFound.Encoder.EncodeFields((NotFound)value, writer);
                    return;
                }
                if (value is TooManyFiles)
                {
                    WriteProperty(".tag", "too_many_files", writer, enc.StringEncoder.Instance);
                    TooManyFiles.Encoder.EncodeFields((TooManyFiles)value, writer);
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
        /// <para>Decoder for  <see cref="SaveCopyReferenceError" />.</para>
        /// </summary>
        private class SaveCopyReferenceErrorDecoder : enc.UnionDecoder<SaveCopyReferenceError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SaveCopyReferenceError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SaveCopyReferenceError Create()
            {
                return new SaveCopyReferenceError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SaveCopyReferenceError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "invalid_copy_reference":
                        return InvalidCopyReference.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    case "not_found":
                        return NotFound.Decoder.DecodeFields(reader);
                    case "too_many_files":
                        return TooManyFiles.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The path object</para>
        /// </summary>
        public sealed class Path : SaveCopyReferenceError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(WriteError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public WriteError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Files.WriteError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return new Path();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Path value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path":
                            value.Value = Dropbox.Api.Files.WriteError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The copy reference is invalid.</para>
        /// </summary>
        public sealed class InvalidCopyReference : SaveCopyReferenceError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidCopyReference> Encoder = new InvalidCopyReferenceEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidCopyReference> Decoder = new InvalidCopyReferenceDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidCopyReference" />
            /// class.</para>
            /// </summary>
            private InvalidCopyReference()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidCopyReference</para>
            /// </summary>
            public static readonly InvalidCopyReference Instance = new InvalidCopyReference();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidCopyReference" />.</para>
            /// </summary>
            private class InvalidCopyReferenceEncoder : enc.StructEncoder<InvalidCopyReference>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidCopyReference value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidCopyReference" />.</para>
            /// </summary>
            private class InvalidCopyReferenceDecoder : enc.StructDecoder<InvalidCopyReference>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidCopyReference"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidCopyReference Create()
                {
                    return new InvalidCopyReference();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InvalidCopyReference DecodeFields(enc.IJsonReader reader)
                {
                    return InvalidCopyReference.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>You don't have permission to save the given copy reference. Please make sure
        /// this app is same app which created the copy reference and the source user is still
        /// linked to the app.</para>
        /// </summary>
        public sealed class NoPermission : SaveCopyReferenceError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return new NoPermission();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoPermission DecodeFields(enc.IJsonReader reader)
                {
                    return NoPermission.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The file referenced by the copy reference cannot be found.</para>
        /// </summary>
        public sealed class NotFound : SaveCopyReferenceError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFound> Encoder = new NotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFound> Decoder = new NotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundEncoder : enc.StructEncoder<NotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundDecoder : enc.StructDecoder<NotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFound Create()
                {
                    return new NotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NotFound DecodeFields(enc.IJsonReader reader)
                {
                    return NotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The operation would involve more than 10,000 files and folders.</para>
        /// </summary>
        public sealed class TooManyFiles : SaveCopyReferenceError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyFiles> Encoder = new TooManyFilesEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyFiles> Decoder = new TooManyFilesDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyFiles" />
            /// class.</para>
            /// </summary>
            private TooManyFiles()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyFiles</para>
            /// </summary>
            public static readonly TooManyFiles Instance = new TooManyFiles();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyFiles" />.</para>
            /// </summary>
            private class TooManyFilesEncoder : enc.StructEncoder<TooManyFiles>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyFiles value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyFiles" />.</para>
            /// </summary>
            private class TooManyFilesDecoder : enc.StructDecoder<TooManyFiles>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyFiles" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyFiles Create()
                {
                    return new TooManyFiles();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override TooManyFiles DecodeFields(enc.IJsonReader reader)
                {
                    return TooManyFiles.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SaveCopyReferenceError
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
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
