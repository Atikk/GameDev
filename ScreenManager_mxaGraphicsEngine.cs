using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.GraphicsEng {
    namespace Insma.Mxa.Framework.Content
    {
        public class ContentManager : IDisposable
        {
            public ContentManager(IServiceProvider serviceProvider) { throw new NotImplementedException(); }
            public ContentManager(IServiceProvider serviceProvider, string rootDirectory) { throw new NotImplementedException(); }
            public void Dispose() { throw new NotImplementedException(); }
            protected virtual void Dispose(bool disposing) { throw new NotImplementedException(); }
            public virtual T Load<T>(string assetName) { throw new NotImplementedException(); }
            protected virtual Stream OpenStream(string assetName) { throw new NotImplementedException(); }
            protected T ReadAsset<T>(string assetName, Action<IDisposable> recordDisposableObject) { throw new NotImplementedException(); }
            public virtual void Unload() { throw new NotImplementedException(); }

            public string RootDirectory { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public IServiceProvider ServiceProvider { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public class GameTime
        {
            public GameTime() { throw new NotImplementedException(); }
            public GameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime) { throw new NotImplementedException(); }
            public GameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly) { throw new NotImplementedException(); }

            public TimeSpan ElapsedGameTime { get { throw new NotImplementedException(); } internal set { throw new NotImplementedException(); } }
            public bool IsRunningSlowly { get { throw new NotImplementedException(); } internal set { throw new NotImplementedException(); } }
            public TimeSpan TotalGameTime { get { throw new NotImplementedException(); } internal set { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum GraphicsProfile
        {
            Reach = 0,
            HiDef = 1,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum SurfaceFormat
        {
            Color = 0,
            Bgr565 = 1,
            Bgra5551 = 2,
            Bgra4444 = 3,
            Dxt1 = 4,
            Dxt3 = 5,
            Dxt5 = 6,
            NormalizedByte2 = 7,
            NormalizedByte4 = 8,
            Rgba1010102 = 9,
            Rg32 = 10,
            Rgba64 = 11,
            Alpha8 = 12,
            Single = 13,
            Vector2 = 14,
            Vector4 = 15,
            HalfSingle = 16,
            HalfVector2 = 17,
            HalfVector4 = 18,
            HdrBlendable = 19,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class DisplayMode
        {
            public override string ToString() { throw new NotImplementedException(); }

            public float AspectRatio { get { throw new NotImplementedException(); } }
            public SurfaceFormat Format { get { throw new NotImplementedException(); } }
            public int Height { get { throw new NotImplementedException(); } }
            public Rectangle TitleSafeArea { get { throw new NotImplementedException(); } }
            public int Width { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class DisplayModeCollection : IEnumerable<DisplayMode>, IEnumerable
        {
            public IEnumerator<DisplayMode> GetEnumerator() { throw new NotImplementedException(); }
            public IEnumerable<DisplayMode> this[SurfaceFormat format] { get { throw new NotImplementedException(); } }
            IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum DepthFormat
        {
            None = 0,
            Depth16 = 1,
            Depth24 = 2,
            Depth24Stencil8 = 3,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public sealed class GraphicsAdapter
        {
            public bool IsProfileSupported(GraphicsProfile graphicsProfile) { throw new NotImplementedException(); }
            public bool QueryBackBufferFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount) { throw new NotImplementedException(); }
            public bool QueryRenderTargetFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount) { throw new NotImplementedException(); }

            public static ReadOnlyCollection<GraphicsAdapter> Adapters { get { throw new NotImplementedException(); } }
            public DisplayMode CurrentDisplayMode { get { throw new NotImplementedException(); } }
            public static GraphicsAdapter DefaultAdapter { get { throw new NotImplementedException(); } }
            public string Description { get { throw new NotImplementedException(); } }
            public int DeviceId { get { throw new NotImplementedException(); } }
            public string DeviceName { get { throw new NotImplementedException(); } }
            public bool IsDefaultAdapter { get { throw new NotImplementedException(); } }
            public bool IsWideScreen { get { throw new NotImplementedException(); } }
            public IntPtr MonitorHandle { get { throw new NotImplementedException(); } }
            public int Revision { get { throw new NotImplementedException(); } }
            public int SubSystemId { get { throw new NotImplementedException(); } }
            public DisplayModeCollection SupportedDisplayModes { get { throw new NotImplementedException(); } }
            public static bool UseNullDevice { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public static bool UseReferenceDevice { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public int VendorId { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum ClearOptions
        {
            Target = 1,
            DepthBuffer = 2,
            Stencil = 4,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum PrimitiveType
        {
            TriangleList = 0,
            TriangleStrip = 1,
            LineList = 2,
            LineStrip = 3,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public struct RenderTargetBinding
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public struct VertexBufferBinding
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public sealed class ResourceCreatedEventArgs : EventArgs
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public sealed class ResourceDestroyedEventArgs : EventArgs
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public abstract class Texture : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class Texture2D : Texture
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class RenderTarget2D : Texture2D
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class PresentationParameters
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class TextureCube : Texture
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class RenderTargetCube : TextureCube
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum CubeMapFace
        {
            PositiveX = 0,
            NegativeX = 1,
            PositiveY = 2,
            NegativeY = 3,
            PositiveZ = 4,
            NegativeZ = 5,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class VertexBuffer : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class BlendState : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class DepthStencilState : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public enum GraphicsDeviceStatus
        {
            Normal = 0,
            Lost = 1,
            NotReset = 2,
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class IndexBuffer : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public sealed class TextureCollection
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public sealed class SamplerStateCollection
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class RasterizerState : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Vector2 : IEquatable<Vector2>
        {
            public float X;
            public float Y;

            public Vector2(float x, float y) { throw new NotImplementedException(); }
            public Vector2(float value) { throw new NotImplementedException(); }

            public static Vector2 Add(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2) { throw new NotImplementedException(); }
            public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount) { throw new NotImplementedException(); }
            public static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float amount, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max) { throw new NotImplementedException(); }
            public static void Clamp(ref Vector2 value1, ref Vector2 min, ref Vector2 max, out Vector2 result) { throw new NotImplementedException(); }
            public static float Distance(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result) { throw new NotImplementedException(); }
            public static float DistanceSquared(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result) { throw new NotImplementedException(); }
            public static Vector2 Divide(Vector2 value1, float divider) { throw new NotImplementedException(); }
            public static Vector2 Divide(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Divide(ref Vector2 value1, float divider, out Vector2 result) { throw new NotImplementedException(); }
            public static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result) { throw new NotImplementedException(); }
            public static float Dot(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result) { throw new NotImplementedException(); }
            public bool Equals(Vector2 other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount) { throw new NotImplementedException(); }
            public static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2, float amount, out Vector2 result) { throw new NotImplementedException(); }
            public float Length() { throw new NotImplementedException(); }
            public float LengthSquared() { throw new NotImplementedException(); }
            public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount) { throw new NotImplementedException(); }
            public static void Lerp(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Max(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Max(ref Vector2 value1, ref Vector2 value2, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Min(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Min(ref Vector2 value1, ref Vector2 value2, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Multiply(Vector2 value1, float scaleFactor) { throw new NotImplementedException(); }
            public static Vector2 Multiply(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Multiply(ref Vector2 value1, float scaleFactor, out Vector2 result) { throw new NotImplementedException(); }
            public static void Multiply(ref Vector2 value1, ref Vector2 value2, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Negate(Vector2 value) { throw new NotImplementedException(); }
            public static void Negate(ref Vector2 value, out Vector2 result) { throw new NotImplementedException(); }
            public void Normalize() { throw new NotImplementedException(); }
            public static Vector2 Normalize(Vector2 value) { throw new NotImplementedException(); }
            public static void Normalize(ref Vector2 value, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Reflect(Vector2 vector, Vector2 normal) { throw new NotImplementedException(); }
            public static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount) { throw new NotImplementedException(); }
            public static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 Subtract(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static Vector2 Transform(Vector2 position, Matrix matrix) { throw new NotImplementedException(); }
            public static Vector2 Transform(Vector2 value, Quaternion rotation) { throw new NotImplementedException(); }
            public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray) { throw new NotImplementedException(); }
            public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray) { throw new NotImplementedException(); }
            public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result) { throw new NotImplementedException(); }
            public static Vector2 TransformNormal(Vector2 normal, Matrix matrix) { throw new NotImplementedException(); }
            public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void TransformNormal(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray) { throw new NotImplementedException(); }
            public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result) { throw new NotImplementedException(); }

            public static bool operator !=(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static bool operator ==(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static Vector2 operator +(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static Vector2 operator -(Vector2 value) { throw new NotImplementedException(); }
            public static Vector2 operator -(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static Vector2 operator *(float scaleFactor, Vector2 value) { throw new NotImplementedException(); }
            public static Vector2 operator *(Vector2 value, float scaleFactor) { throw new NotImplementedException(); }
            public static Vector2 operator *(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }
            public static Vector2 operator /(Vector2 value1, float divider) { throw new NotImplementedException(); }
            public static Vector2 operator /(Vector2 value1, Vector2 value2) { throw new NotImplementedException(); }

            public static Vector2 One { get { throw new NotImplementedException(); } }
            public static Vector2 UnitX { get { throw new NotImplementedException(); } }
            public static Vector2 UnitY { get { throw new NotImplementedException(); } }
            public static Vector2 Zero { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Vector3 : IEquatable<Vector3>
        {
            public float X;
            public float Y;
            public float Z;

            public Vector3(float value) { throw new NotImplementedException(); }
            public Vector3(float x, float y, float z) { throw new NotImplementedException(); }
            public Vector3(Vector2 value, float z) { throw new NotImplementedException(); }

            public static Vector3 Add(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2) { throw new NotImplementedException(); }
            public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1, float amount2, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount) { throw new NotImplementedException(); }
            public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float amount, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max) { throw new NotImplementedException(); }
            public static void Clamp(ref Vector3 value1, ref Vector3 min, ref Vector3 max, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Cross(Vector3 vector1, Vector3 vector2) { throw new NotImplementedException(); }
            public static void Cross(ref Vector3 vector1, ref Vector3 vector2, out Vector3 result) { throw new NotImplementedException(); }
            public static float Distance(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result) { throw new NotImplementedException(); }
            public static float DistanceSquared(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result) { throw new NotImplementedException(); }
            public static Vector3 Divide(Vector3 value1, float value2) { throw new NotImplementedException(); }
            public static Vector3 Divide(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Divide(ref Vector3 value1, float value2, out Vector3 result) { throw new NotImplementedException(); }
            public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException(); }
            public static float Dot(Vector3 vector1, Vector3 vector2) { throw new NotImplementedException(); }
            public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result) { throw new NotImplementedException(); }
            public bool Equals(Vector3 other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount) { throw new NotImplementedException(); }
            public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result) { throw new NotImplementedException(); }
            public float Length() { throw new NotImplementedException(); }
            public float LengthSquared() { throw new NotImplementedException(); }
            public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount) { throw new NotImplementedException(); }
            public static void Lerp(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Max(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Min(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Multiply(Vector3 value1, float scaleFactor) { throw new NotImplementedException(); }
            public static Vector3 Multiply(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result) { throw new NotImplementedException(); }
            public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Negate(Vector3 value) { throw new NotImplementedException(); }
            public static void Negate(ref Vector3 value, out Vector3 result) { throw new NotImplementedException(); }
            public void Normalize() { throw new NotImplementedException(); }
            public static Vector3 Normalize(Vector3 value) { throw new NotImplementedException(); }
            public static void Normalize(ref Vector3 value, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Reflect(Vector3 vector, Vector3 normal) { throw new NotImplementedException(); }
            public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount) { throw new NotImplementedException(); }
            public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 Subtract(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static Vector3 Transform(Vector3 position, Matrix matrix) { throw new NotImplementedException(); }
            public static Vector3 Transform(Vector3 value, Quaternion rotation) { throw new NotImplementedException(); }
            public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray) { throw new NotImplementedException(); }
            public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray) { throw new NotImplementedException(); }
            public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result) { throw new NotImplementedException(); }
            public static Vector3 TransformNormal(Vector3 normal, Matrix matrix) { throw new NotImplementedException(); }
            public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray) { throw new NotImplementedException(); }
            public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result) { throw new NotImplementedException(); }

            public static bool operator !=(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static bool operator ==(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static Vector3 operator +(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static Vector3 operator -(Vector3 value) { throw new NotImplementedException(); }
            public static Vector3 operator -(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static Vector3 operator *(float scaleFactor, Vector3 value) { throw new NotImplementedException(); }
            public static Vector3 operator *(Vector3 value, float scaleFactor) { throw new NotImplementedException(); }
            public static Vector3 operator *(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }
            public static Vector3 operator /(Vector3 value, float divider) { throw new NotImplementedException(); }
            public static Vector3 operator /(Vector3 value1, Vector3 value2) { throw new NotImplementedException(); }

            public static Vector3 Backward { get { throw new NotImplementedException(); } }
            public static Vector3 Down { get { throw new NotImplementedException(); } }
            public static Vector3 Forward { get { throw new NotImplementedException(); } }
            public static Vector3 Left { get { throw new NotImplementedException(); } }
            public static Vector3 One { get { throw new NotImplementedException(); } }
            public static Vector3 Right { get { throw new NotImplementedException(); } }
            public static Vector3 UnitX { get { throw new NotImplementedException(); } }
            public static Vector3 UnitY { get { throw new NotImplementedException(); } }
            public static Vector3 UnitZ { get { throw new NotImplementedException(); } }
            public static Vector3 Up { get { throw new NotImplementedException(); } }
            public static Vector3 Zero { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Quaternion : IEquatable<Quaternion>
        {
            public float X;
            public float Y;
            public float Z;
            public float W;

            public Quaternion(float x, float y, float z, float w) { throw new NotImplementedException(); }
            public Quaternion(Vector3 vectorPart, float scalarPart) { throw new NotImplementedException(); }
            public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion Concatenate(Quaternion value1, Quaternion value2) { throw new NotImplementedException(); }
            public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result) { throw new NotImplementedException(); }
            public void Conjugate() { throw new NotImplementedException(); }
            public static Quaternion Conjugate(Quaternion value) { throw new NotImplementedException(); }
            public static void Conjugate(ref Quaternion value, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle) { throw new NotImplementedException(); }
            public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion CreateFromRotationMatrix(Matrix matrix) { throw new NotImplementedException(); }
            public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll) { throw new NotImplementedException(); }
            public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result) { throw new NotImplementedException(); }
            public static float Dot(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result) { throw new NotImplementedException(); }
            public bool Equals(Quaternion other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public static Quaternion Inverse(Quaternion quaternion) { throw new NotImplementedException(); }
            public static void Inverse(ref Quaternion quaternion, out Quaternion result) { throw new NotImplementedException(); }
            public float Length() { throw new NotImplementedException(); }
            public float LengthSquared() { throw new NotImplementedException(); }
            public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount) { throw new NotImplementedException(); }
            public static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor) { throw new NotImplementedException(); }
            public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result) { throw new NotImplementedException(); }
            public static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion Negate(Quaternion quaternion) { throw new NotImplementedException(); }
            public static void Negate(ref Quaternion quaternion, out Quaternion result) { throw new NotImplementedException(); }
            public void Normalize() { throw new NotImplementedException(); }
            public static Quaternion Normalize(Quaternion quaternion) { throw new NotImplementedException(); }
            public static void Normalize(ref Quaternion quaternion, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount) { throw new NotImplementedException(); }
            public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result) { throw new NotImplementedException(); }
            public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }

            public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static Quaternion operator -(Quaternion quaternion) { throw new NotImplementedException(); }
            public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static Quaternion operator *(Quaternion quaternion1, float scaleFactor) { throw new NotImplementedException(); }
            public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }
            public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2) { throw new NotImplementedException(); }

            public static Quaternion Identity { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public enum PlaneIntersectionType
        {
            Front = 0,
            Back = 1,
            Intersecting = 2,
        }
    }
    namespace Insma.Mxa.Framework
    {
        public enum ContainmentType
        {
            Disjoint = 0,
            Contains = 1,
            Intersects = 2,
        }
    }
    namespace Insma.Mxa.Framework
    {
        public class BoundingFrustum : IEquatable<BoundingFrustum>
        {
            public BoundingFrustum(Matrix value) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingBox box) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingSphere sphere) { throw new NotImplementedException(); }
            public ContainmentType Contains(Vector3 point) { throw new NotImplementedException(); }
            public void Contains(ref BoundingBox box, out ContainmentType result) { throw new NotImplementedException(); }
            public void Contains(ref BoundingSphere sphere, out ContainmentType result) { throw new NotImplementedException(); }
            public void Contains(ref Vector3 point, out ContainmentType result) { throw new NotImplementedException(); }
            public bool Equals(BoundingFrustum other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public Vector3[] GetCorners() { throw new NotImplementedException(); }
            public void GetCorners(Vector3[] corners) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public bool Intersects(BoundingBox box) { throw new NotImplementedException(); }
            public bool Intersects(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public bool Intersects(BoundingSphere sphere) { throw new NotImplementedException(); }
            public PlaneIntersectionType Intersects(Plane plane) { throw new NotImplementedException(); }
            public float? Intersects(Ray ray) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingBox box, out bool result) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingSphere sphere, out bool result) { throw new NotImplementedException(); }
            public void Intersects(ref Plane plane, out PlaneIntersectionType result) { throw new NotImplementedException(); }
            public void Intersects(ref Ray ray, out float? result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static bool operator !=(BoundingFrustum a, BoundingFrustum b) { throw new NotImplementedException(); }
            public static bool operator ==(BoundingFrustum a, BoundingFrustum b) { throw new NotImplementedException(); }
            public Plane Bottom { get { throw new NotImplementedException(); } }
            public Plane Far { get { throw new NotImplementedException(); } }
            public Plane Left { get { throw new NotImplementedException(); } }
            public Matrix Matrix { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Plane Near { get { throw new NotImplementedException(); } }
            public Plane Right { get { throw new NotImplementedException(); } }
            public Plane Top { get { throw new NotImplementedException(); } }
            public const int CornerCount = 8;
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct BoundingSphere : IEquatable<BoundingSphere>
        {
            public Vector3 Center;
            public float Radius;

            public BoundingSphere(Vector3 center, float radius) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingBox box) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingSphere sphere) { throw new NotImplementedException(); }
            public ContainmentType Contains(Vector3 point) { throw new NotImplementedException(); }
            public void Contains(ref BoundingBox box, out ContainmentType result) { throw new NotImplementedException(); }
            public void Contains(ref BoundingSphere sphere, out ContainmentType result) { throw new NotImplementedException(); }
            public void Contains(ref Vector3 point, out ContainmentType result) { throw new NotImplementedException(); }
            public static BoundingSphere CreateFromBoundingBox(BoundingBox box) { throw new NotImplementedException(); }
            public static void CreateFromBoundingBox(ref BoundingBox box, out BoundingSphere result) { throw new NotImplementedException(); }
            public static BoundingSphere CreateFromFrustum(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public static BoundingSphere CreateFromPoints(System.Collections.Generic.IEnumerable<Vector3> points) { throw new NotImplementedException(); }
            public static BoundingSphere CreateMerged(BoundingSphere original, BoundingSphere additional) { throw new NotImplementedException(); }
            public static void CreateMerged(ref BoundingSphere original, ref BoundingSphere additional, out BoundingSphere result) { throw new NotImplementedException(); }
            public bool Equals(BoundingSphere other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public bool Intersects(BoundingBox box) { throw new NotImplementedException(); }
            public bool Intersects(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public bool Intersects(BoundingSphere sphere) { throw new NotImplementedException(); }
            public PlaneIntersectionType Intersects(Plane plane) { throw new NotImplementedException(); }
            public float? Intersects(Ray ray) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingBox box, out bool result) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingSphere sphere, out bool result) { throw new NotImplementedException(); }
            public void Intersects(ref Plane plane, out PlaneIntersectionType result) { throw new NotImplementedException(); }
            public void Intersects(ref Ray ray, out float? result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public BoundingSphere Transform(Matrix matrix) { throw new NotImplementedException(); }
            public void Transform(ref Matrix matrix, out BoundingSphere result) { throw new NotImplementedException(); }
            public static bool operator !=(BoundingSphere a, BoundingSphere b) { throw new NotImplementedException(); }
            public static bool operator ==(BoundingSphere a, BoundingSphere b) { throw new NotImplementedException(); }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Ray : IEquatable<Ray>
        {
            public Vector3 Position;
            public Vector3 Direction;

            public Ray(Vector3 position, Vector3 direction) { this.Position = position; this.Direction = direction; }
            public bool Equals(Ray other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public float? Intersects(BoundingBox box) { throw new NotImplementedException(); }
            public float? Intersects(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public float? Intersects(BoundingSphere sphere) { throw new NotImplementedException(); }
            public float? Intersects(Plane plane) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingBox box, out float? result) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingSphere sphere, out float? result) { throw new NotImplementedException(); }
            public void Intersects(ref Plane plane, out float? result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static bool operator !=(Ray a, Ray b) { throw new NotImplementedException(); }
            public static bool operator ==(Ray a, Ray b) { throw new NotImplementedException(); }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct BoundingBox : IEquatable<BoundingBox>
        {
            public BoundingBox(Vector3 min, Vector3 max) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingBox box) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public ContainmentType Contains(BoundingSphere sphere) { throw new NotImplementedException(); }
            public ContainmentType Contains(Vector3 point) { throw new NotImplementedException(); }
            public void Contains(ref BoundingBox box, out ContainmentType result) { throw new NotImplementedException(); }
            public void Contains(ref BoundingSphere sphere, out ContainmentType result) { throw new NotImplementedException(); }
            public void Contains(ref Vector3 point, out ContainmentType result) { throw new NotImplementedException(); }
            public static BoundingBox CreateFromPoints(IEnumerable<Vector3> points) { throw new NotImplementedException(); }
            public static BoundingBox CreateFromSphere(BoundingSphere sphere) { throw new NotImplementedException(); }
            public static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBox result) { throw new NotImplementedException(); }
            public static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional) { throw new NotImplementedException(); }
            public static void CreateMerged(ref BoundingBox original, ref BoundingBox additional, out BoundingBox result) { throw new NotImplementedException(); }
            public bool Equals(BoundingBox other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public Vector3[] GetCorners() { throw new NotImplementedException(); }
            public void GetCorners(Vector3[] corners) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public bool Intersects(BoundingBox box) { throw new NotImplementedException(); }
            public bool Intersects(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public bool Intersects(BoundingSphere sphere) { throw new NotImplementedException(); }
            public PlaneIntersectionType Intersects(Plane plane) { throw new NotImplementedException(); }
            public float? Intersects(Ray ray) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingBox box, out bool result) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingSphere sphere, out bool result) { throw new NotImplementedException(); }
            public void Intersects(ref Plane plane, out PlaneIntersectionType result) { throw new NotImplementedException(); }
            public void Intersects(ref Ray ray, out float? result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static bool operator !=(BoundingBox a, BoundingBox b) { throw new NotImplementedException(); }
            public static bool operator ==(BoundingBox a, BoundingBox b) { throw new NotImplementedException(); }
            public Vector3 Max;
            public Vector3 Min;
            public const int CornerCount = 8;
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Plane : IEquatable<Plane>
        {
            public float D;
            public Vector3 Normal;

            public Plane(float a, float b, float c, float d) { throw new NotImplementedException(); }
            public Plane(Vector3 normal, float d) { throw new NotImplementedException(); }
            public Plane(Vector3 point1, Vector3 point2, Vector3 point3) { throw new NotImplementedException(); }
            public Plane(Vector4 value) { throw new NotImplementedException(); }
            public float Dot(Vector4 value) { throw new NotImplementedException(); }
            public void Dot(ref Vector4 value, out float result) { throw new NotImplementedException(); }
            public float DotCoordinate(Vector3 value) { throw new NotImplementedException(); }
            public void DotCoordinate(ref Vector3 value, out float result) { throw new NotImplementedException(); }
            public float DotNormal(Vector3 value) { throw new NotImplementedException(); }
            public void DotNormal(ref Vector3 value, out float result) { throw new NotImplementedException(); }
            public bool Equals(Plane other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public PlaneIntersectionType Intersects(BoundingBox box) { throw new NotImplementedException(); }
            public PlaneIntersectionType Intersects(BoundingFrustum frustum) { throw new NotImplementedException(); }
            public PlaneIntersectionType Intersects(BoundingSphere sphere) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingBox box, out PlaneIntersectionType result) { throw new NotImplementedException(); }
            public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result) { throw new NotImplementedException(); }
            public void Normalize() { throw new NotImplementedException(); }
            public static Plane Normalize(Plane value) { throw new NotImplementedException(); }
            public static void Normalize(ref Plane value, out Plane result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static Plane Transform(Plane plane, Matrix matrix) { throw new NotImplementedException(); }
            public static Plane Transform(Plane plane, Quaternion rotation) { throw new NotImplementedException(); }
            public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result) { throw new NotImplementedException(); }
            public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result) { throw new NotImplementedException(); }
            public static bool operator !=(Plane lhs, Plane rhs) { throw new NotImplementedException(); }
            public static bool operator ==(Plane lhs, Plane rhs) { throw new NotImplementedException(); }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Matrix : IEquatable<Matrix>
        {
            public float M11;
            public float M12;
            public float M13;
            public float M14;
            public float M21;
            public float M22;
            public float M23;
            public float M24;
            public float M31;
            public float M32;
            public float M33;
            public float M34;
            public float M41;
            public float M42;
            public float M43;
            public float M44;

            public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) { throw new NotImplementedException(); }

            public static Matrix Add(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector) { throw new NotImplementedException(); }
            public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector) { throw new NotImplementedException(); }
            public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateFromAxisAngle(Vector3 axis, float angle) { throw new NotImplementedException(); }
            public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateFromQuaternion(Quaternion quaternion) { throw new NotImplementedException(); }
            public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll) { throw new NotImplementedException(); }
            public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector) { throw new NotImplementedException(); }
            public static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane) { throw new NotImplementedException(); }
            public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane) { throw new NotImplementedException(); }
            public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance) { throw new NotImplementedException(); }
            public static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance) { throw new NotImplementedException(); }
            public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance) { throw new NotImplementedException(); }
            public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateReflection(Plane value) { throw new NotImplementedException(); }
            public static void CreateReflection(ref Plane value, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateRotationX(float radians) { throw new NotImplementedException(); }
            public static void CreateRotationX(float radians, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateRotationY(float radians) { throw new NotImplementedException(); }
            public static void CreateRotationY(float radians, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateRotationZ(float radians) { throw new NotImplementedException(); }
            public static void CreateRotationZ(float radians, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateScale(float scale) { throw new NotImplementedException(); }
            public static void CreateScale(float scale, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateScale(float xScale, float yScale, float zScale) { throw new NotImplementedException(); }
            public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateScale(Vector3 scales) { throw new NotImplementedException(); }
            public static void CreateScale(ref Vector3 scales, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateShadow(Vector3 lightDirection, Plane plane) { throw new NotImplementedException(); }
            public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition) { throw new NotImplementedException(); }
            public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateTranslation(Vector3 position) { throw new NotImplementedException(); }
            public static void CreateTranslation(ref Vector3 position, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up) { throw new NotImplementedException(); }
            public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result) { throw new NotImplementedException(); }
            public bool Decompose(out Vector3 scale, out Quaternion rotation, out Vector3 translation) { throw new NotImplementedException(); }
            public float Determinant() { throw new NotImplementedException(); }
            public static Matrix Divide(Matrix matrix1, float divider) { throw new NotImplementedException(); }
            public static Matrix Divide(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static void Divide(ref Matrix matrix1, float divider, out Matrix result) { throw new NotImplementedException(); }
            public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException(); }
            public bool Equals(Matrix other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public static Matrix Invert(Matrix matrix) { throw new NotImplementedException(); }
            public static void Invert(ref Matrix matrix, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount) { throw new NotImplementedException(); }
            public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix Multiply(Matrix matrix1, float scaleFactor) { throw new NotImplementedException(); }
            public static Matrix Multiply(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static void Multiply(ref Matrix matrix1, float scaleFactor, out Matrix result) { throw new NotImplementedException(); }
            public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix Negate(Matrix matrix) { throw new NotImplementedException(); }
            public static void Negate(ref Matrix matrix, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix Subtract(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static Matrix Transform(Matrix value, Quaternion rotation) { throw new NotImplementedException(); }
            public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result) { throw new NotImplementedException(); }
            public static Matrix Transpose(Matrix matrix) { throw new NotImplementedException(); }
            public static void Transpose(ref Matrix matrix, out Matrix result) { throw new NotImplementedException(); }

            public static bool operator !=(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static bool operator ==(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static Matrix operator +(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static Matrix operator -(Matrix matrix1) { throw new NotImplementedException(); }
            public static Matrix operator -(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static Matrix operator *(float scaleFactor, Matrix matrix) { throw new NotImplementedException(); }
            public static Matrix operator *(Matrix matrix, float scaleFactor) { throw new NotImplementedException(); }
            public static Matrix operator *(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }
            public static Matrix operator /(Matrix matrix1, float divider) { throw new NotImplementedException(); }
            public static Matrix operator /(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException(); }

            public Vector3 Backward { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Vector3 Down { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Vector3 Forward { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public static Matrix Identity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Vector3 Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Vector3 Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Vector3 Translation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public Vector3 Up { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework
    {
        public struct Vector4 : IEquatable<Vector4>
        {
            public float X;
            public float Y;
            public float Z;
            public float W;

            public Vector4(float value) { throw new NotImplementedException(); }
            public Vector4(float x, float y, float z, float w) { throw new NotImplementedException(); }
            public Vector4(Vector2 value, float z, float w) { throw new NotImplementedException(); }
            public Vector4(Vector3 value, float w) { throw new NotImplementedException(); }

            public static Vector4 Add(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2) { throw new NotImplementedException(); }
            public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount) { throw new NotImplementedException(); }
            public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max) { throw new NotImplementedException(); }
            public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result) { throw new NotImplementedException(); }
            public static float Distance(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result) { throw new NotImplementedException(); }
            public static float DistanceSquared(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result) { throw new NotImplementedException(); }
            public static Vector4 Divide(Vector4 value1, float divider) { throw new NotImplementedException(); }
            public static Vector4 Divide(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Divide(ref Vector4 value1, float divider, out Vector4 result) { throw new NotImplementedException(); }
            public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException(); }
            public static float Dot(Vector4 vector1, Vector4 vector2) { throw new NotImplementedException(); }
            public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result) { throw new NotImplementedException(); }
            public bool Equals(Vector4 other) { throw new NotImplementedException(); }
            public override bool Equals(object obj) { throw new NotImplementedException(); }
            public override int GetHashCode() { throw new NotImplementedException(); }
            public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount) { throw new NotImplementedException(); }
            public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result) { throw new NotImplementedException(); }
            public float Length() { throw new NotImplementedException(); }
            public float LengthSquared() { throw new NotImplementedException(); }
            public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount) { throw new NotImplementedException(); }
            public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Max(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Min(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Multiply(Vector4 value1, float scaleFactor) { throw new NotImplementedException(); }
            public static Vector4 Multiply(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result) { throw new NotImplementedException(); }
            public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Negate(Vector4 value) { throw new NotImplementedException(); }
            public static void Negate(ref Vector4 value, out Vector4 result) { throw new NotImplementedException(); }
            public void Normalize() { throw new NotImplementedException(); }
            public static Vector4 Normalize(Vector4 vector) { throw new NotImplementedException(); }
            public static void Normalize(ref Vector4 vector, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount) { throw new NotImplementedException(); }
            public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result) { throw new NotImplementedException(); }
            public static Vector4 Subtract(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }
            public static Vector4 Transform(Vector2 position, Matrix matrix) { throw new NotImplementedException(); }
            public static Vector4 Transform(Vector2 value, Quaternion rotation) { throw new NotImplementedException(); }
            public static Vector4 Transform(Vector3 position, Matrix matrix) { throw new NotImplementedException(); }
            public static Vector4 Transform(Vector3 value, Quaternion rotation) { throw new NotImplementedException(); }
            public static Vector4 Transform(Vector4 vector, Matrix matrix) { throw new NotImplementedException(); }
            public static Vector4 Transform(Vector4 value, Quaternion rotation) { throw new NotImplementedException(); }
            public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException(); }
            public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray) { throw new NotImplementedException(); }
            public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray) { throw new NotImplementedException(); }
            public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result) { throw new NotImplementedException(); }
            public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result) { throw new NotImplementedException(); }

            public static bool operator !=(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static bool operator ==(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static Vector4 operator +(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static Vector4 operator -(Vector4 value) { throw new NotImplementedException(); }
            public static Vector4 operator -(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static Vector4 operator *(float scaleFactor, Vector4 value1) { throw new NotImplementedException(); }
            public static Vector4 operator *(Vector4 value1, float scaleFactor) { throw new NotImplementedException(); }
            public static Vector4 operator *(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }
            public static Vector4 operator /(Vector4 value1, float divider) { throw new NotImplementedException(); }
            public static Vector4 operator /(Vector4 value1, Vector4 value2) { throw new NotImplementedException(); }

            public static Vector4 One { get { throw new NotImplementedException(); } }
            public static Vector4 UnitW { get { throw new NotImplementedException(); } }
            public static Vector4 UnitX { get { throw new NotImplementedException(); } }
            public static Vector4 UnitY { get { throw new NotImplementedException(); } }
            public static Vector4 UnitZ { get { throw new NotImplementedException(); } }
            public static Vector4 Zero { get { throw new NotImplementedException(); } }
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public interface IVertexType
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class VertexDeclaration : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class GraphicsDevice : IDisposable
        {
            public GraphicsDevice(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters) { throw new NotImplementedException(); }

            public void Clear(Color color) { throw new NotImplementedException(); }
            public void Clear(ClearOptions options, Color color, float depth, int stencil) { throw new NotImplementedException(); }
            public void Clear(ClearOptions options, Vector4 color, float depth, int stencil) { throw new NotImplementedException(); }
            public void Dispose() { throw new NotImplementedException(); }
            protected virtual void Dispose(bool p1) { throw new NotImplementedException(); }
            public void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount) { throw new NotImplementedException(); }
            public void DrawInstancedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount, int instanceCount) { throw new NotImplementedException(); }
            public void DrawPrimitives(PrimitiveType primitiveType, int startVertex, int primitiveCount) { throw new NotImplementedException(); }
            public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType { throw new NotImplementedException(); }
            public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct { throw new NotImplementedException(); }
            public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType { throw new NotImplementedException(); }
            public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct { throw new NotImplementedException(); }
            public void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount) where T : struct, IVertexType { throw new NotImplementedException(); }
            public void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct { throw new NotImplementedException(); }
            public void GetBackBufferData<T>(Rectangle? rect, T[] data, int startIndex, int elementCount) where T : struct { throw new NotImplementedException(); }
            public void GetBackBufferData<T>(T[] data) where T : struct { throw new NotImplementedException(); }
            public void GetBackBufferData<T>(T[] data, int startIndex, int elementCount) where T : struct { throw new NotImplementedException(); }
            public RenderTargetBinding[] GetRenderTargets() { throw new NotImplementedException(); }
            public VertexBufferBinding[] GetVertexBuffers() { throw new NotImplementedException(); }
            public void Present() { throw new NotImplementedException(); }
            public void Present(Rectangle? sourceRectangle, Rectangle? destinationRectangle, IntPtr overrideWindowHandle) { throw new NotImplementedException(); }
            protected void raise_DeviceLost(object sender, EventArgs eventArgs) { throw new NotImplementedException(); }
            protected void raise_DeviceReset(object sender, EventArgs eventArgs) { throw new NotImplementedException(); }
            protected void raise_DeviceResetting(object sender, EventArgs eventArgs) { throw new NotImplementedException(); }
            protected void raise_Disposing(object sender, EventArgs eventArgs) { throw new NotImplementedException(); }
            protected void raise_ResourceCreated(object sender, ResourceCreatedEventArgs resourceCreatedEventArgs) { throw new NotImplementedException(); }
            protected void raise_ResourceDestroyed(object sender, ResourceDestroyedEventArgs resourceCreatedEventArgs) { throw new NotImplementedException(); }
            public void Reset() { throw new NotImplementedException(); }
            public void Reset(PresentationParameters presentationParameters) { throw new NotImplementedException(); }
            public void Reset(PresentationParameters presentationParameters, GraphicsAdapter graphicsAdapter) { throw new NotImplementedException(); }
            public void SetRenderTarget(RenderTarget2D renderTarget) { throw new NotImplementedException(); }
            public void SetRenderTarget(RenderTargetCube renderTarget, CubeMapFace cubeMapFace) { throw new NotImplementedException(); }
            public void SetRenderTargets(params RenderTargetBinding[] renderTargets) { throw new NotImplementedException(); }
            public void SetVertexBuffer(VertexBuffer vertexBuffer) { throw new NotImplementedException(); }
            public void SetVertexBuffer(VertexBuffer vertexBuffer, int vertexOffset) { throw new NotImplementedException(); }
            public void SetVertexBuffers(params VertexBufferBinding[] vertexBuffers) { throw new NotImplementedException(); }

            public GraphicsAdapter Adapter { get { throw new NotImplementedException(); } }
            public Color BlendFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public BlendState BlendState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public DepthStencilState DepthStencilState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public DisplayMode DisplayMode { get { throw new NotImplementedException(); } }
            public GraphicsDeviceStatus GraphicsDeviceStatus { get { throw new NotImplementedException(); } }
            public GraphicsProfile GraphicsProfile { get { throw new NotImplementedException(); } }
            public IndexBuffer Indices { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public bool IsDisposed { get { throw new NotImplementedException(); } }
            public int MultiSampleMask { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public PresentationParameters PresentationParameters { get { throw new NotImplementedException(); } }
            public RasterizerState RasterizerState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public int ReferenceStencil { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public SamplerStateCollection SamplerStates { get { throw new NotImplementedException(); } }
            public Rectangle ScissorRectangle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public TextureCollection Textures { get { throw new NotImplementedException(); } }
            public SamplerStateCollection VertexSamplerStates { get { throw new NotImplementedException(); } }
            public TextureCollection VertexTextures { get { throw new NotImplementedException(); } }
            public Viewport Viewport { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public event EventHandler<EventArgs> DeviceLost;
            public event EventHandler<EventArgs> DeviceReset;
            public event EventHandler<EventArgs> DeviceResetting;
            public event EventHandler<EventArgs> Disposing;
            public event EventHandler<EventArgs> DrawGuide;
            public event EventHandler<ResourceCreatedEventArgs> ResourceCreated;
            public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public struct Viewport
        {
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public abstract class GraphicsResource : IDisposable
        {
            public GraphicsDevice _parent;

            public void Dispose() { throw new NotImplementedException(); }
            protected virtual void Dispose(bool disposing) { throw new NotImplementedException(); }
            protected void raise_Disposing(object sender, EventArgs eventArgs) { throw new NotImplementedException(); }
            public override string ToString() { throw new NotImplementedException(); }

            public GraphicsDevice GraphicsDevice { get { throw new NotImplementedException(); } }
            public bool IsDisposed { get { throw new NotImplementedException(); } }
            public string Name { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public object Tag { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public event EventHandler<EventArgs> Disposing;
        }
    }
    namespace Insma.Mxa.Framework.Graphics
    {
        public class SpriteBatch : GraphicsResource
        {
        }
    }
    namespace Insma.Mxa.Framework
    {
        public class Game : IDisposable
        {
            public Game() { throw new NotImplementedException(); }

            public void Dispose() { throw new NotImplementedException(); }
            public void Exit() { throw new NotImplementedException(); }
            public void ResetElapsedTime() { throw new NotImplementedException(); }
            public void Run() { throw new NotImplementedException(); }
            public void RunOneFrame() { throw new NotImplementedException(); }
            public void SuppressDraw() { throw new NotImplementedException(); }
            public void Tick() { throw new NotImplementedException(); }
            protected virtual bool BeginDraw() { throw new NotImplementedException(); }
            protected virtual void BeginRun() { throw new NotImplementedException(); }
            protected virtual void Dispose(bool disposing) { throw new NotImplementedException(); }
            protected virtual void Draw(GameTime gameTime) { throw new NotImplementedException(); }
            protected virtual void EndDraw() { throw new NotImplementedException(); }
            protected virtual void EndRun() { throw new NotImplementedException(); }
            protected virtual void Initialize() { throw new NotImplementedException(); }
            protected virtual void LoadContent() { throw new NotImplementedException(); }
            protected virtual bool ShowMissingRequirementMessage(Exception exception) { throw new NotImplementedException(); }
            protected virtual void UnloadContent() { throw new NotImplementedException(); }
            protected virtual void Update(GameTime gameTime) { throw new NotImplementedException(); }
            protected virtual void OnActivated(object sender, EventArgs args) { throw new NotImplementedException(); }
            protected virtual void OnDeactivated(object sender, EventArgs args) { throw new NotImplementedException(); }
            protected virtual void OnExiting(object sender, EventArgs args) { throw new NotImplementedException(); }

            public GameComponentCollection Components { get { throw new NotImplementedException(); } }
            public ContentManager Content { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public GraphicsDevice GraphicsDevice { get { throw new NotImplementedException(); } }
            public TimeSpan InactiveSleepTime { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public bool IsActive { get { throw new NotImplementedException(); } }
            public bool IsFixedTimeStep { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public bool IsMouseVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public LaunchParameters LaunchParameters { get { throw new NotImplementedException(); } }
            public GameServiceContainer Services { get { throw new NotImplementedException(); } }
            public TimeSpan TargetElapsedTime { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            public GameWindow Window { get { throw new NotImplementedException(); } }

            public event EventHandler<EventArgs> Activated;
            public event EventHandler<EventArgs> Deactivated;
            public event EventHandler<EventArgs> Disposed;
            public event EventHandler<EventArgs> Exiting;
        }
    }


}

namespace RPG
{
    class ScreenManager
    {
        private static ScreenManager instance;
        public GraphicsEng.Insma.Mxa.Framework.Vector2 Dimensions
        { private set; get; }
        public static ScreenManager Instance
        { get
            { if (instance==null) instance = new ScreenManager(); return instance;
            }
        }
            
        public void LoadContent(RPG.GraphicsEng.Insma.Mxa.Framework.Content.ContentManager Content)
        { }
        public void UnloadContent()
        { }
        public void Update(RPG.GraphicsEng.Insma.Mxa.Framework.GameTime gameTime)
        { }
        public void Draw(RPG.GraphicsEng.Insma.Mxa.Framework.Graphics.SpriteBatch spriteBatch)
        { }
        
    }
}
