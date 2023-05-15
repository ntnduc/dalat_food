import _ from 'lodash';

export default class AppUtil{

    static ToNumberPrice(number: string){
        return _.toNumber(number);
    }

    static GetShowMoney(price: string){
        return new Intl.NumberFormat('vi-VN', {maximumSignificantDigits: 7}).format(this.ToNumberPrice(price));
    }
}