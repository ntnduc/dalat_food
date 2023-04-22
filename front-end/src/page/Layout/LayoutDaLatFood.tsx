import './style/layout-style.scss';

import { Avatar, Badge, Layout, Menu, MenuProps, theme } from 'antd';
const { Header, Content } = Layout;

import Icon, { ShoppingOutlined, UserOutlined } from '@ant-design/icons';
import Sider from 'antd/es/layout/Sider';
import _ from 'lodash';
import { Link, Route, Switch, useLocation } from 'react-router-dom';
import { routers } from 'Routes';

import LOGO from '../../logo.svg';

const LayoutDaLatFood = () => {
    const location = useLocation();

    const {
        token: { colorBgContainer },
    } = theme.useToken();

    const onLogin = () => {
        console.log('login');
    };

    const handleMenu = (): MenuProps['items'] => {
        const menus = _.map(routers, item => {
            return {
                key: item.path,
                label: (
                    <Link to={item.path}>
                        {item.name}
                    </Link>
                ),
                icon: <Icon type={'message'} />
            };
        }) as MenuProps['items'];
        return menus;
    };

    // const handleComponent = () => {
    //     const componentRoute: JSX.Element[] = [];
    //     _.forEach(routers, item => {
    //         if (item.isDefault) {
    //             componentRoute.push(<Route exact
    //                 path={'/'}
    //                 component={item.component} />);
    //         }
    //         componentRoute.push(<Route path={item.path} component={item.component} />);
    //     });
    //     console.log('🚀 ~ file: LayoutDaLatFood.tsx:49 ~ handleComponent ~ componentRoute:', componentRoute);
    //     return componentRoute;
    // };

    return (
        <Layout className='layout-dalat-food'>
            <Header style={{ position: 'sticky', top: 0, zIndex: 1, width: '100%' }} className='custom-header'>
                <div
                    style={{
                        float: 'left',
                        width: 120,
                        height: 31,
                        margin: '16px 24px 16px 0',
                        background: 'rgba(255, 255, 255, 0.2)',
                    }}
                />
                <div className='logo'>
                    <img src={LOGO} alt="Da Lat Food Logo" />
                </div>
                <div className='content-right'>
                    <div className='user-cart'>
                        <Badge count={2} className='user-cart-count'>
                            <ShoppingOutlined style={{ fontSize: 30, opacity: 0.4 }} />
                        </Badge>
                        Giỏ Hàng
                    </div>
                    <div className='user-login' onClick={onLogin}>
                        <Avatar className='avatar-user'
                            size={30}
                            icon={<UserOutlined />} />
                        Đăng Nhập
                    </div>
                </div>

            </Header>

            <Layout className='site-layout' style={{ padding: '24px 0', background: colorBgContainer }}>
                <Sider style={{ background: colorBgContainer }} width={200}>
                    <Menu
                        mode="inline"
                        style={{ height: '100%' }}
                        defaultSelectedKeys={[location.pathname === '/' ? '/product' : location.pathname]}
                        items={handleMenu()}
                    />
                </Sider>
                <Content style={{ padding: '0 24px', minHeight: 280 }}>
                    <Switch>
                        {_.map(routers, item => item.isDefault && <Route exact
                            path={'/'}
                            component={item.component} />)}
                        {_.map(routers, item => <Route path={item.path} component={item.component} />)}
                        {/* <Route exact
                            path={'/'}
                            component={ProductList} />
                        <Route path={'/product'} component={ProductList} />
                        <Route path={'/admin'} component={AdminPage} /> */}
                    </Switch>
                </Content>
            </Layout>
            {/* <Content className="site-layout" >
                <div style={{padding: 24, minHeight: 380, background: colorBgContainer}}>Content</div>
            </Content> */}
            {/* <Footer style={{textAlign: 'center'}}>Ant Design ©2023 Created by Ant UED</Footer> */}
        </Layout>
    );
};

export default LayoutDaLatFood;