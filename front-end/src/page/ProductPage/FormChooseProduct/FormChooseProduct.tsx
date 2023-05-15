import './style/form-choose-product.scss';

import { Carousel } from 'antd';

export const FormChooseProduct = () => {
    return (
        <div className="form-choose-product"
            style={{ height: 400 }}>
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
