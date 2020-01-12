import { Chart } from './Chart';
import { Quote } from './Quote';

export class StockData {
    id: number;
    quote: Quote;
    chart: Chart[];
}
