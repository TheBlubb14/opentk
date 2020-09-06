using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// OpenGL context implemented using GLFW.
    /// </summary>
    public unsafe class GLFWGraphicsContext : IGraphicsContext
    {
        private readonly Window* _windowPtr;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWGraphicsContext"/> class, a GLFW managed opengl context.
        /// </summary>
        /// <param name="windowPtr">The window pointer that is associated with the context.</param>
        public GLFWGraphicsContext(Window* windowPtr)
        {
            _windowPtr = windowPtr;
        }

        /// <inheritdoc />
        public bool IsCurrent => GLFW.GetCurrentContext() == _windowPtr;

        /// <inheritdoc />
        public void SwapBuffers()
        {
            GLFW.SwapBuffers(_windowPtr);
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            GLFW.MakeContextCurrent(_windowPtr);
        }

        /// <inheritdoc />
        public void MakeNoneCurrent()
        {
            GLFW.MakeContextCurrent(null);
        }
    }
}
