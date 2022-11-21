using ConversionApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using SourceGeneration.Application;
using System.Windows;

namespace ConversionApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        #region Methods

        /// <summary>
        /// シェルを作成します。
        /// </summary>
        /// <returns>作成したシェルを返します。</returns>
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// 型を登録します。
        /// </summary>
        /// <param name="containerRegistry">コンテナーのレジストリー</param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        /// <summary>
        /// モジュールカタログを設定します。
        /// </summary>
        /// <param name="moduleCatalog">モジュールカタログ</param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module>();
        }

        #endregion

        #region Nested types

        /// <summary>
        /// モジュール
        /// </summary>
        private class Module : IModule
        {
            #region Fields

            /// <summary>
            /// リージョンマネージャー
            /// </summary>
            private readonly IRegionManager _regionManager;

            #endregion

            #region Constructors

            /// <summary>
            /// モジュールを初期化します。
            /// </summary>
            /// <param name="regionManager">リージョンマネージャー</param>
            public Module(IRegionManager regionManager)
            {
                _regionManager = regionManager;
            }

            #endregion

            #region Methods

            /// <summary>
            /// 初期化された際に実行されます。
            /// </summary>
            /// <param name="containerProvider">コンテナーのプロパイダー</param>
            public void OnInitialized(IContainerProvider containerProvider)
            {
                _regionManager.RequestNavigate("Main", nameof(NewFileCreationView));
            }

            /// <summary>
            /// 型を登録します。
            /// </summary>
            /// <param name="containerRegistry">コンテナーのレジストリー</param>
            public void RegisterTypes(IContainerRegistry containerRegistry)
            {
                containerRegistry.RegisterForNavigation<NewFileCreationView>();
                containerRegistry.RegisterForNavigation<FileConversionView>();
                containerRegistry.RegisterForNavigation<SingleFileConversionView>();
                containerRegistry.RegisterForNavigation<MultipleFileConversionView>();

                containerRegistry.RegisterSingleton<IFileTypeQueryService, FileTypeQueryService>();
                containerRegistry.RegisterSingleton<IFileCreationApplicationService, FileCreationApplicationService>();
                containerRegistry.RegisterSingleton<IFileConversionApplicationService, FileConversionApplicationService>();
            }

            #endregion
        }

        #endregion
    }
}
