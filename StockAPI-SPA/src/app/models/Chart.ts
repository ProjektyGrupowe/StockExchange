export class Chart {
    chartID: number;
    date: Date;
    open: number;
    close: number;
    high: number;
    low: number;
    volume: number;
    uOpen: number;
    uClose: number;
    uHigh: number;
    uLow: number;
    uVolume: number;
    change: number;
    changePercent: number;
    label: string;
    changeOverTime: number;
    stockDataID: number;
    stockData?: any;
}
