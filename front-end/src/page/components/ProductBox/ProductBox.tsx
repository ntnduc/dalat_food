import './style/product-box-style.scss';

import { Card } from 'antd';
import Meta from 'antd/es/card/Meta';
import React from 'react';

export const ProductBox = () => {
    return (
        <Card
            className='product-box'
            hoverable
            cover={<img alt="example" src="https://os.alipayobjects.com/rmsportal/QBnOOoLaAfKPirc.png" />}
        >
            <Meta title="Europe Street beat" description="www.instagram.com" />
        </Card>
    );
};
