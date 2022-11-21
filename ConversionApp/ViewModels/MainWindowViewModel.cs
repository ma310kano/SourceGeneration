using ConversionApp.Views;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;

namespace ConversionApp.ViewModels
{
    /// <summary>
    /// メインウィンドウ(ViewModel)
    /// </summary>
    internal class MainWindowViewModel : BindableBase
    {
        #region Fields

        /// <summary>
        /// メインのリージョン名
        /// </summary>
        private const string MainRegionName = "Main";

        /// <summary>
        /// リージョンマネージャー
        /// </summary>
        private readonly IRegionManager _regionManager;

        #endregion

        #region Constructors

        /// <summary>
        /// メインウィンドウ(ViewModel)
        /// </summary>
        /// <param name="regionManager">リージョンマネージャー</param>
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateToNewFileCreationViewCommand = new ReactiveCommand().WithSubscribe(NavigateToNewFileCreationView);
            NavigateToFileConversionViewCommand = new ReactiveCommand().WithSubscribe(NavigateToFileConversionView);
        }

        #endregion

        #region Properties

        /// <summary>
        /// ファイルを新規作成する画面へ遷移するコマンドを取得します。
        /// </summary>
        public ReactiveCommand NavigateToNewFileCreationViewCommand { get; }

        /// <summary>
        /// ファイルを変換する画面へ遷移するコマンドを取得します。
        /// </summary>
        public ReactiveCommand NavigateToFileConversionViewCommand { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 新規ファイルを新規作成する画面へ遷移します。
        /// </summary>
        private void NavigateToNewFileCreationView()
        {
            _regionManager.RequestNavigate(MainRegionName, nameof(NewFileCreationView));
        }

        /// <summary>
        /// ファイルを変換する画面へ遷移します。
        /// </summary>
        private void NavigateToFileConversionView()
        {
            _regionManager.RequestNavigate(MainRegionName, nameof(FileConversionView));
        }

        #endregion
    }
}
