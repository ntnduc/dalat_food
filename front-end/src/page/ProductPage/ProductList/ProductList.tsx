import './style/product-list.scss';

import useRequest, { ApiResponse } from 'common/customHook/useRequest';
import DaLatSwiper from 'component/DaLatSwiper';
import Loading from 'component/Loading';
import IMAGE_ADV from 'image/colored-vegetables-fresh-ripe-white-background-3-4.jpg';
import _ from 'lodash';
import { useEffect } from 'react';
import { useMergeState } from 'use-merge-state';
import AppUtil from 'util/AppUtil';

import AdvComponent from '../AdvComponent/AdvComponent';
import { ProductBox } from '../ProductBox/ProductBox';
import { Type_Product_Api } from './interface/ProductInterface';

interface State {
    data?: Array<Type_Product_Api>,
    loading: boolean
}

const ProductList = () => {
    const { get } = useRequest();
    const [state, setState] = useMergeState<State>({
        data: [],
        loading: true
    });

    useEffect(() => {
        loadData();
    }, []);

    const loadData = () => {
        let result: Array<Type_Product_Api> = [];
        get<Array<Type_Product_Api>>('/api/product/list').then(
            (response: ApiResponse<Array<Type_Product_Api>>) => {
                if (response.success) {
                    result = response.result as Array<Type_Product_Api>;
                    setState({
                        loading: false,
                        data: result
                    });
                }
            });
    };

    if (state.loading) {
        return <Loading />;
    }

    return (
        <div className='wrap-body-product-content'>
            <DaLatSwiper
                breakpoints={{
                    768: {
                        slidesPerView: 2
                    }
                }}>
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
            </DaLatSwiper>
            {/* <div className='wrap-adv-content grid grid-cols-2 gap-5 pb-5'>
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
                <AdvComponent tabContent={'Sản phẩm tươi sống'}
                    title={'Miễn phí rau củ sống từ cửa hàng chúng tôi'}
                    description={'Đã sẵn sàng cho những khách hàng đầu tiên đến với cửa hàng chúng tôi. Rau củ tươi trực tiếp từ Đà Lạt'}
                    backgroundImage={IMAGE_ADV} />
            </div> */}
            <div className='product-list grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 2xl:grid-cols-5 gap-6'>
                {_.map(state.data, (product) => {
                    return <div className='wrap-content-product'>
                        <ProductBox nameProduct={_.get(product, 'name', '')}
                            price={AppUtil.GetShowMoney(product.price)}
                            shortInfo={_.get(product, 'desc', 'Đang cập nhật...')} />
                    </div>;

                })}
            </div>
        </div >
    );
};
export default ProductList;