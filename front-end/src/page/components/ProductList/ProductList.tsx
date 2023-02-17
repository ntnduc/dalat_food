import './style/product-list.scss';

import useRequest from 'common/customHook/useRequest';
import Loading from 'component/Loading';
import _ from 'lodash';
import { useEffect } from 'react';
import { useMergeState } from 'use-merge-state';

import { ProductBox } from '../ProductBox/ProductBox';

const ProductList = () => {
    const { get } = useRequest();
    const [state, setState] = useMergeState({
        data: null,
        loading: true
    });
    useEffect(() => {
        loadData();
    }, []);

    const loadData = async () => {
        const result = await get('/beverages');
        if (result) {
            setState({
                data: result,
                loading: false
            });
        }
    };

    if (state.loading) {
        return <Loading />;
    }
    return (
        <div className='product-list grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 2xl:grid-cols-5 gap-6'>
            {_.map(state.data, (product) => {
                return <div className='wrap-content-product'>
                    <ProductBox nameProduct={_.get(product, 'name', '')}
                        price={_.get(product, 'price', 1) + 1000}
                        shortInfo={_.get(product, 'desc', 'Đang cập nhật...')} />
                </div>;

            })}
        </div>
    );
};
export default ProductList;