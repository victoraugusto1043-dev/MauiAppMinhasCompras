using Android.App;
using Android.Runtime;

namespace MauiAppMinhasCompras
{
    // Remover o atributo [Application] pois "Application" não é um atributo válido.
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
