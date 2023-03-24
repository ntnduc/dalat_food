import './style/product-box-style.scss';

import { Card, Modal } from 'antd';
import _ from 'lodash';
import React, { useState } from 'react';
import CountUp from 'react-countup';
import AppUtil from 'util/AppUtil';

import { FormChooseProduct } from '../FormChooseProduct/FormChooseProduct';

interface Props{
    nameProduct: string,
    price?: string,
    ranglePrice?: Array<string>,
    oldPrice?: string,
    shortInfo?: string
}

export const ProductBox = (props:Props) => {

    const [openModal, setOpenModal] = useState<boolean>(false);

    const onChooseProduct = () => {
        setOpenModal(true);
    };

    const handleCanlceModal = ()=>{
        setOpenModal(false);
    };
    
    return (
        <>
            <Card
                cover={<img className='image-product'
                    alt="example"
                    src="https://os.alipayobjects.com/rmsportal/QBnOOoLaAfKPirc.png" />}
                className='product-box'
                hoverable
                onClick={onChooseProduct}
            >
                <div className='name-product'>
                    <h1> {props.nameProduct} </h1>
                </div>

                <div className='short-info'>
                    <h2> {_.get(props, 'shortInfo', 'Đang cập nhật thông tin sản phẩm...')} </h2>
                </div>

                <div className='price-product'> 
                    {props.ranglePrice && <div className="price range-price">
                        <span className='unit'>đ</span>
                        <span> {_.get(props, 'ranglePrice[0]')} </span>
                        <span> - </span>
                        <span className='unit'>đ</span>
                        <span> {_.get(props, 'ranglePrice[1]')} </span>
                    </div> }

                    {props.price && <div className='price single-price'>
                        <span> <CountUp end={AppUtil.ToNumberPrice(props.price)}
                            duration={0.6}
                            separator='.'
                            start={AppUtil.ToNumberPrice(props.price) / 5} /> </span>
                        <span className='unit'>đ</span>
                    </div>} 

                    {props.oldPrice && <div className="old-price">
                        <span> {props.oldPrice} </span>
                    </div> }
                </div>
            </Card>
            <Modal
                open={openModal}
                onCancel={handleCanlceModal}
                footer={null}
            >
                <div className="wrap-form-choose-product">
                    <FormChooseProduct/>
                </div>
            </Modal>
        </>
    );
};
