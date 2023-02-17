import './style/form-choose-product.scss';

import { Carousel } from 'antd';
import React, { useEffect } from 'react';

import useRequest, { ApiResponse } from '../../../common/customHook/useRequest';

export const FormChooseProduct = () => {
    const {get, post } = useRequest();
    const getData = async () => {
        console.log('runnn');
        const param = {
            'fullName' :'Huy Xuan',
            'email': '[email protected]',
            'phone': '012345678',
            'password': '12345678',
            'address': 'p.Linh Tây, Tp.Thủ Đức, Tp.Hồ Chí Minh'
        };
        const data = post('https://freeapi.code4func.com/api/v1//user/sign-up', param ); 
        console.log('🚀 -> getData -> data', data);
    }; 

    useEffect(() => {
        getData();
    }, []);
    return (
        <div className="form-choose-product"
            style={{height: 400}}>
            <Carousel autoplay={true} dotPosition={'top'}>
                <div>
                    <h3>1</h3>
                </div>
                <div>
                    <h3>2</h3>
                </div>
                <div>
                    <h3>3</h3>
                </div>
                <div>
                    <h3>4</h3>
                </div>
            </Carousel>
        </div>
    );
};
