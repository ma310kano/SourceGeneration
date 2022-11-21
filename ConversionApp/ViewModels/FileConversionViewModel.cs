using ConversionApp.Views;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;

namespace ConversionApp.ViewModels
{
    /// <summary>
    /// ファイルを変換する画面(ViewModel)
    /// </summary>
    internal class FileConversionViewModel : BindableBase, INavigationAware
    {
        #region Fields

        /// <summary>
        /// ボディのリージョン名
        /// </summary>
        private const string BodyRegionName = "Body";

        /// <summary>
        /// リージョンマネージャー
        /// </summary>
        private readonly IRegionManager _regionManager;

        #endregion

        #region Constructors

        /// <summary>
        /// ファイルを変換する画面(ViewModel)を初期化します。
        /// </summary>
        /// <param name="regionManager">リージョンマネージャー</param>
        public FileConversionViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateToSingleFileConversionViewCommand = new ReactiveCommand().WithSubscribe(NavigateToSingleFileConversionView);
            NavigateToMultipleFileConversionViewCommand = new ReactiveCommand().WithSubscribe(NavigateToMultipleFileConversionView);
        }

        #endregion

        #region Properties

        /// <summary>
        /// 1つのファイルを変換する画面へ遷移するコマンドを取得します。
        /// </summary>
        public ReactiveCommand NavigateToSingleFileConversionViewCommand { get; }

        /// <summary>
        /// 複数のファイルを変換する画面へ遷移するコマンドを取得します。
        /// </summary>
        public ReactiveCommand NavigateToMultipleFileConversionViewCommand { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 引数で渡されたコンテキストのターゲットとなる画面かどうかを返します。
        /// </summary>
        /// <param name="navigationContext">遷移時のコンテキストを表します。</param>
        /// <returns>ターゲットとなる画面の場合は、 <c>true</c>。それ以外の場合は、 <c>false</c>。</returns>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// 画面から離れるときに呼び出されます。
        /// </summary>
        /// <param name="navigationContext">遷移時のコンテキストを表します。</param>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        /// <summary>
        /// 画面に遷移してきたときに呼び出されます。
        /// </summary>
        /// <param name="navigationContext">遷移時のコンテキストを表します。</param>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            NavigateToSingleFileConversionView();
        }

        /// <summary>
        /// 1つのファイルを変換する画面へ遷移します。
        /// </summary>
        private void NavigateToSingleFileConversionView()
        {
            _regionManager.RequestNavigate(BodyRegionName, nameof(SingleFileConversionView));
        }

        /// <summary>
        /// 複数のファイルを変換する画面へ遷移します。
        /// </summary>
        private void NavigateToMultipleFileConversionView()
        {
            _regionManager.RequestNavigate(BodyRegionName, nameof(MultipleFileConversionView));
        }

        #endregion
    }
}
