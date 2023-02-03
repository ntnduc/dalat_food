import './style/product-list.scss';

import _ from 'lodash';

import { ProductBox } from '../ProductBox/ProductBox';

const ProductList = () => {
    const productList = _.range(1, 12); 
    return (
        <div className='product-list grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 2xl:grid-cols-5 gap-6'>
            {_.map(productList, item => {
                return <div className='wrap-content-product'>
                    <ProductBox/>
                </div>;

            })}
        </div>
    );
};
export default ProductList;