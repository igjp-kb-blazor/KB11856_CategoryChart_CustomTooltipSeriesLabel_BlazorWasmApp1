const OnSeriesAddedScript = (chart, args) => {
    switch (args.series.title) {
        case 'S1':
            args.series.title = "America";
            break;
    }
}

igRegisterScript("OnSeriesAddedScript", OnSeriesAddedScript, false);